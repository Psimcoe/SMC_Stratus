using StratusRevit.RevitAdapter.Abstractions;

namespace StratusRevit.Domain;

public class ChangeMapper
{
    private readonly MappingConfig _config;

    public ChangeMapper(MappingConfig config)
    {
        _config = config;
    }

    public IReadOnlyList<ChangeIntent> Map(
        IReadOnlyList<RevitElementData> elements,
        string stratusObjectType,
        IReadOnlyDictionary<string, string?> currentStratusValues)
    {
        var intents = new List<ChangeIntent>();

        foreach (var element in elements)
        {
            // Resolve the Stratus Part ID from the configured Revit parameter
            var stratusId = ResolveStratusId(element);

            FieldChange? trackingStatusChange = null;
            var customFieldChanges = new List<FieldChange>();

            foreach (var rule in _config.FieldMappings)
            {
                if (!element.Parameters.TryGetValue(rule.RevitParameter, out var rawRevitValue))
                    continue;

                var revitValue = Normalize(rawRevitValue, rule.Normalization);
                if (revitValue is null)
                    continue;

                currentStratusValues.TryGetValue(rule.StratusField, out var currentStratusValue);

                var effectivePolicy = rule.ConflictPolicyOverride ?? _config.ConflictPolicy;
                if (effectivePolicy == ConflictPolicy.StratusWins && currentStratusValue is not null)
                    continue;
                if (effectivePolicy == ConflictPolicy.DoNotChange)
                    continue;
                if (!rule.AllowOverwriteNonEmpty && currentStratusValue is not null && currentStratusValue.Length > 0)
                    continue;

                var change = new FieldChange(
                    rule.StratusField,
                    currentStratusValue,
                    revitValue,
                    rule.IsCompanyField,
                    rule.CompanyFieldId);

                if (rule.IsTrackingStatus)
                    trackingStatusChange = change;
                else
                    customFieldChanges.Add(change);
            }

            intents.Add(new ChangeIntent(
                StratusObjectId: stratusId,
                StratusObjectType: stratusObjectType,
                RevitElementId: element.ElementId,
                RevitUniqueId: element.UniqueId,
                TrackingStatusChange: trackingStatusChange,
                CustomFieldChanges: customFieldChanges.AsReadOnly(),
                IsValid: true,
                ValidationErrors: Array.Empty<string>()
            ));
        }

        return intents.AsReadOnly();
    }

    /// <summary>
    /// Extracts the Stratus Part ID from the element using:
    ///   1. <see cref="MappingConfig.StratusQrCodeParameter"/> (raw QR value – caller resolves via API)
    ///   2. <see cref="MappingConfig.StratusIdParameter"/>     (direct Part ID)
    ///   3. Falls back to Revit UniqueId.
    /// </summary>
    private string ResolveStratusId(RevitElementData element)
    {
        // Prefer a direct Stratus Part ID parameter
        if (_config.StratusIdParameter is not null
            && element.Parameters.TryGetValue(_config.StratusIdParameter, out var directId)
            && !string.IsNullOrWhiteSpace(directId))
        {
            return directId;
        }

        // QR code parameter – store the raw QR value; caller/engine will resolve
        if (_config.StratusQrCodeParameter is not null
            && element.Parameters.TryGetValue(_config.StratusQrCodeParameter, out var qrValue)
            && !string.IsNullOrWhiteSpace(qrValue))
        {
            return $"qr:{qrValue}";
        }

        // Fallback: Revit UniqueId (works if CadId in Stratus == Revit UniqueId)
        return element.UniqueId;
    }

    private static string? Normalize(string? value, NormalizationRule? rule)
    {
        if (value is null) return null;
        if (rule is null) return value;
        if (rule.Trim) value = value.Trim();
        if (rule.ToLower) value = value.ToLowerInvariant();
        if (rule.ToUpper) value = value.ToUpperInvariant();
        return value;
    }
}
