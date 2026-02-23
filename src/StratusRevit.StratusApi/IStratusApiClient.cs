namespace StratusRevit.StratusApi;

public interface IStratusApiClient
{
    Task<IReadOnlyList<TrackingStatusDto>> GetTrackingStatusesAsync(CancellationToken ct = default);
    Task<IReadOnlyList<FieldDto>> GetCompanyFieldsAsync(CancellationToken ct = default);
    Task<TrackingStatusUpdateResponse> UpdateAssemblyTrackingStatusAsync(string assemblyId, TrackingStatusUpdateRequest request, CancellationToken ct = default);
    Task UpdateAssemblyFieldAsync(string assemblyId, string fieldId, string value, CancellationToken ct = default);
    Task UpdateAssemblyFieldsAsync(string assemblyId, IReadOnlyList<FieldValuePair> fields, CancellationToken ct = default);
    Task<AssemblyDto?> GetAssemblyAsync(string assemblyId, CancellationToken ct = default);
}
