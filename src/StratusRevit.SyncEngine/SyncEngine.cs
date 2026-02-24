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
        var intents = _mapper.Map(elements, "Assembly", new Dictionary<string, string?>());
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

        var statuses = await _apiClient.GetTrackingStatusesAsync(ct);
        var fields = await _apiClient.GetCompanyFieldsAsync(ct);

        var validStatusIds = new HashSet<string>(statuses.Select(s => s.Id));
        var editableFieldNames = new HashSet<string>(fields.Where(f => f.IsEditable).Select(f => f.Name));

        var validator = new ChangeValidator(validStatusIds, editableFieldNames);
        var intents = _mapper.Map(elements, "Assembly", new Dictionary<string, string?>());
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

    private async Task<ChangeResult> ApplyTrackingStatusAsync(ChangeIntent intent, CancellationToken ct)
    {
        try
        {
            var req = new TrackingStatusUpdateRequest { TrackingStatusId = intent.TrackingStatusChange!.NewValue };
            await _apiClient.UpdateAssemblyTrackingStatusAsync(intent.StratusObjectId, req, ct);
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
            await _apiClient.UpdateAssemblyFieldAsync(intent.StratusObjectId, fieldChange.FieldName, fieldChange.NewValue, ct);
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
