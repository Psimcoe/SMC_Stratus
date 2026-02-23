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

                var change = new FieldChange(rule.StratusField, currentStratusValue, revitValue);

                if (rule.IsTrackingStatus)
                    trackingStatusChange = change;
                else
                    customFieldChanges.Add(change);
            }

            intents.Add(new ChangeIntent(
                StratusObjectId: element.UniqueId,
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
