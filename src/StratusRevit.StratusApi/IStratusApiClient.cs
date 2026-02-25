namespace StratusRevit.StratusApi;

public interface IStratusApiClient
{
    // ── Company ──────────────────────────────────────────────
    Task<IReadOnlyList<TrackingStatusDto>> GetTrackingStatusesAsync(CancellationToken ct = default);
    Task<IReadOnlyList<FieldDto>> GetCompanyFieldsAsync(CancellationToken ct = default);

    // ── Part – Read ──────────────────────────────────────────
    /// <summary>GET /v2/part/{id}  (includes properties, fields, points)</summary>
    Task<PartDto?> GetPartAsync(string partId, bool includeStratusProperties = false, CancellationToken ct = default);

    /// <summary>GET /v1/part/{qrCode}  – look up a part by its QR-code value.</summary>
    Task<PartDto?> GetPartByQrCodeAsync(string qrCode, CancellationToken ct = default);

    /// <summary>GET /v1/part?page=…&amp;pagesize=…</summary>
    Task<PagedResponse<PartDto>> GetPartsAsync(int page = 0, int pageSize = 50, CancellationToken ct = default);

    // ── Part – Tracking Status ───────────────────────────────
    /// <summary>POST /v1/part/{id}/tracking-status</summary>
    Task<TrackingStatusUpdateResponse> UpdatePartTrackingStatusAsync(
        string partId, TrackingStatusUpdateRequest request, bool isCut = true, CancellationToken ct = default);

    // ── Part – Properties (user-defined key/value) ───────────
    /// <summary>PATCH /v1/part/{id}/property  – single property.</summary>
    Task<FieldValuePair> UpdatePartPropertyAsync(string partId, string key, string value, CancellationToken ct = default);

    /// <summary>PATCH /v1/part/properties  – bulk update (up to 1 000 changes).</summary>
    Task UpdatePartPropertiesBulkAsync(IReadOnlyList<BulkPropertyUpdate> updates, CancellationToken ct = default);

    // ── Part – Company Fields (PATCH v2) ─────────────────────
    /// <summary>PATCH /v2/part/{id}/field  – single company field.</summary>
    Task UpdatePartFieldAsync(string partId, string fieldId, string? value, CancellationToken ct = default);

    /// <summary>PATCH /v2/part/{id}/fields  – multiple company fields.</summary>
    Task UpdatePartFieldsAsync(string partId, IReadOnlyList<FieldValuePair> fields, CancellationToken ct = default);
}
