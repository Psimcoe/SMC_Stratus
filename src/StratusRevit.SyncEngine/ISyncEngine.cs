using StratusRevit.RevitAdapter.Abstractions;

namespace StratusRevit.SyncEngine;

public record SyncReport(
    DateTimeOffset GeneratedAt,
    bool IsDryRun,
    int TotalElements,
    int ChangesPlanned,
    int ChangesSucceeded,
    int ChangesFailed,
    IReadOnlyList<ChangeResult> Results
);

public record ChangeResult(
    string StratusObjectId,
    string RevitElementId,
    string FieldName,
    string? OldValue,
    string? NewValue,
    bool IsSuccess,
    string? ErrorMessage,
    DateTimeOffset Timestamp
);

public interface ISyncEngine
{
    Task<SyncReport> DryRunAsync(IReadOnlyList<RevitElementData> elements, CancellationToken ct = default);
    Task<SyncReport> PushUpdatesAsync(IReadOnlyList<RevitElementData> elements, CancellationToken ct = default);
}
