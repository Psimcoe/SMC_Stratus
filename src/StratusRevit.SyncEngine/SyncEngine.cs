using Microsoft.Extensions.Logging;
using StratusRevit.Domain;
using StratusRevit.RevitAdapter.Abstractions;
using StratusRevit.StratusApi;

namespace StratusRevit.SyncEngine;

public class SyncEngine : ISyncEngine
{
    private readonly IStratusApiClient _apiClient;
    private readonly ChangeMapper _mapper;
    private readonly ILogger<SyncEngine> _logger;
    private readonly AuditLogger _audit;

    public SyncEngine(
        IStratusApiClient apiClient,
        ChangeMapper mapper,
        ILogger<SyncEngine> logger,
        AuditLogger audit)
    {
        _apiClient = apiClient;
        _mapper = mapper;
        _logger = logger;
        _audit = audit;
    }

    public async Task<SyncReport> DryRunAsync(IReadOnlyList<RevitElementData> elements, CancellationToken ct = default)
    {
        _logger.LogInformation("DryRun starting for {Count} elements", elements.Count);
        var intents = _mapper.Map(elements, "Part", new Dictionary<string, string?>());
        var results = intents.SelectMany(ToChangeResults).ToList();
        return new SyncReport(
            GeneratedAt: DateTimeOffset.UtcNow,
            IsDryRun: true,
            TotalElements: elements.Count,
            ChangesPlanned: results.Count,
            ChangesSucceeded: 0,
            ChangesFailed: 0,
            Results: results.AsReadOnly()
        );
    }

    public async Task<SyncReport> PushUpdatesAsync(IReadOnlyList<RevitElementData> elements, CancellationToken ct = default)
    {
        _logger.LogInformation("PushUpdates starting for {Count} elements", elements.Count);

        var statuses = await _apiClient.GetTrackingStatusesAsync(ct).ConfigureAwait(false);
        var fields = await _apiClient.GetCompanyFieldsAsync(ct).ConfigureAwait(false);

        // Build a name→ID lookup so Revit display names can be resolved to GUIDs
        var statusNameToId = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        var validStatusIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (var s in statuses)
        {
            validStatusIds.Add(s.Id);
            if (!string.IsNullOrEmpty(s.Name))
                statusNameToId[s.Name] = s.Id;
        }

        var editableFieldNames = new HashSet<string>(fields.Where(f => f.IsEditable).Select(f => f.Name));

        var intents = _mapper.Map(elements, "Part", new Dictionary<string, string?>());

        // Resolve tracking-status display names → IDs (Revit stores names, API needs GUIDs)
        intents = ResolveTrackingStatusNames(intents, statusNameToId);

        // Resolve any QR-code based IDs before validation/push
        intents = await ResolveQrCodeIdsAsync(intents, ct);

        var validator = new ChangeValidator(validStatusIds, editableFieldNames);
        var validated = validator.ValidateAll(intents);

        var succeeded = new List<ChangeResult>();
        var failed = new List<ChangeResult>();

        foreach (var intent in validated.Where(i => i.IsValid))
        {
            if (intent.TrackingStatusChange is not null)
            {
                var result = await ApplyTrackingStatusAsync(intent, ct);
                _audit.LogAttempt(result);
                if (result.IsSuccess) succeeded.Add(result); else failed.Add(result);
            }

            foreach (var fieldChange in intent.CustomFieldChanges)
            {
                var result = await ApplyFieldChangeAsync(intent, fieldChange, ct);
                _audit.LogAttempt(result);
                if (result.IsSuccess) succeeded.Add(result); else failed.Add(result);
            }
        }

        foreach (var intent in validated.Where(i => !i.IsValid))
        {
            var errorResult = new ChangeResult(
                intent.StratusObjectId, intent.RevitElementId,
                "validation", null, null, false,
                string.Join("; ", intent.ValidationErrors),
                DateTimeOffset.UtcNow);
            failed.Add(errorResult);
        }

        return new SyncReport(
            GeneratedAt: DateTimeOffset.UtcNow,
            IsDryRun: false,
            TotalElements: elements.Count,
            ChangesPlanned: succeeded.Count + failed.Count,
            ChangesSucceeded: succeeded.Count,
            ChangesFailed: failed.Count,
            Results: succeeded.Concat(failed).ToList().AsReadOnly()
        );
    }

    // ──────────────── Tracking-status name → ID ────────────────

    /// <summary>
    /// Revit stores tracking-status display names (e.g. "BIM/VDC Released to Prefab")
    /// but the Stratus API expects the tracking-status GUID. Resolve names to IDs here.
    /// </summary>
    private IReadOnlyList<ChangeIntent> ResolveTrackingStatusNames(
        IReadOnlyList<ChangeIntent> intents,
        Dictionary<string, string> statusNameToId)
    {
        var resolved = new List<ChangeIntent>(intents.Count);
        foreach (var intent in intents)
        {
            if (intent.TrackingStatusChange is not null)
            {
                var name = intent.TrackingStatusChange.NewValue;
                if (statusNameToId.TryGetValue(name, out var id))
                {
                    var fixedChange = new FieldChange(
                        intent.TrackingStatusChange.FieldName,
                        intent.TrackingStatusChange.OldValue,
                        id, // use the GUID instead of the display name
                        intent.TrackingStatusChange.IsCompanyField,
                        intent.TrackingStatusChange.CompanyFieldId);
                    resolved.Add(intent with { TrackingStatusChange = fixedChange });
                    continue;
                }
                // If it already looks like a GUID, pass through
                _logger.LogWarning(
                    "Tracking status '{Name}' not found in company statuses for element {ElementId}. " +
                    "Passing as-is (may be a GUID).", name, intent.RevitElementId);
            }
            resolved.Add(intent);
        }
        return resolved.AsReadOnly();
    }

    // ──────────────── QR-code resolution ────────────────

    /// <summary>
    /// For any ChangeIntent whose StratusObjectId starts with "qr:", resolve
    /// the real Part ID via the QR-code lookup API.
    /// </summary>
    private async Task<IReadOnlyList<ChangeIntent>> ResolveQrCodeIdsAsync(
        IReadOnlyList<ChangeIntent> intents, CancellationToken ct)
    {
        var resolved = new List<ChangeIntent>(intents.Count);
        foreach (var intent in intents)
        {
            if (intent.StratusObjectId.StartsWith("qr:", StringComparison.Ordinal))
            {
                var qrCode = intent.StratusObjectId.Substring(3);
                try
                {
                    var part = await _apiClient.GetPartByQrCodeAsync(qrCode, ct).ConfigureAwait(false);
                    if (part is not null)
                    {
                        resolved.Add(intent with { StratusObjectId = part.Id });
                        continue;
                    }
                    _logger.LogWarning("QR code '{QrCode}' not found in Stratus (element {ElementId})", qrCode, intent.RevitElementId);
                }
                catch (Exception ex)
                {
                    _logger.LogWarning(ex, "Failed to resolve QR code '{QrCode}' for element {ElementId}", qrCode, intent.RevitElementId);
                }
            }
            resolved.Add(intent);
        }
        return resolved.AsReadOnly();
    }

    // ──────────────── Apply changes ────────────────

    private async Task<ChangeResult> ApplyTrackingStatusAsync(ChangeIntent intent, CancellationToken ct)
    {
        try
        {
            var req = new TrackingStatusUpdateRequest { TrackingStatusId = intent.TrackingStatusChange!.NewValue };
            await _apiClient.UpdatePartTrackingStatusAsync(intent.StratusObjectId, req, ct: ct).ConfigureAwait(false);
            return new ChangeResult(intent.StratusObjectId, intent.RevitElementId,
                intent.TrackingStatusChange.FieldName,
                intent.TrackingStatusChange.OldValue, intent.TrackingStatusChange.NewValue,
                true, null, DateTimeOffset.UtcNow);
        }
        catch (Exception ex)
        {
            return new ChangeResult(intent.StratusObjectId, intent.RevitElementId,
                intent.TrackingStatusChange!.FieldName,
                intent.TrackingStatusChange.OldValue, intent.TrackingStatusChange.NewValue,
                false, ex.Message, DateTimeOffset.UtcNow);
        }
    }

    private async Task<ChangeResult> ApplyFieldChangeAsync(ChangeIntent intent, FieldChange fieldChange, CancellationToken ct)
    {
        try
        {
            if (fieldChange.IsCompanyField && fieldChange.CompanyFieldId is not null)
            {
                // Company-level field → PATCH /v2/part/{id}/field
                await _apiClient.UpdatePartFieldAsync(intent.StratusObjectId, fieldChange.CompanyFieldId, fieldChange.NewValue, ct).ConfigureAwait(false);
            }
            else
            {
                // User-defined property → PATCH /v1/part/{id}/property
                await _apiClient.UpdatePartPropertyAsync(intent.StratusObjectId, fieldChange.FieldName, fieldChange.NewValue, ct).ConfigureAwait(false);
            }

            return new ChangeResult(intent.StratusObjectId, intent.RevitElementId,
                fieldChange.FieldName, fieldChange.OldValue, fieldChange.NewValue,
                true, null, DateTimeOffset.UtcNow);
        }
        catch (Exception ex)
        {
            return new ChangeResult(intent.StratusObjectId, intent.RevitElementId,
                fieldChange.FieldName, fieldChange.OldValue, fieldChange.NewValue,
                false, ex.Message, DateTimeOffset.UtcNow);
        }
    }

    private static IEnumerable<ChangeResult> ToChangeResults(ChangeIntent intent)
    {
        if (intent.TrackingStatusChange is not null)
            yield return new ChangeResult(intent.StratusObjectId, intent.RevitElementId,
                intent.TrackingStatusChange.FieldName,
                intent.TrackingStatusChange.OldValue, intent.TrackingStatusChange.NewValue,
                true, null, DateTimeOffset.UtcNow);

        foreach (var f in intent.CustomFieldChanges)
            yield return new ChangeResult(intent.StratusObjectId, intent.RevitElementId,
                f.FieldName, f.OldValue, f.NewValue, true, null, DateTimeOffset.UtcNow);
    }
}
