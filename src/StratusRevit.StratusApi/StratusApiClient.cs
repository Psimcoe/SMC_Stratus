using System.Net.Http.Json;
using System.Text.Json;
using Microsoft.Extensions.Logging;

namespace StratusRevit.StratusApi;

public class StratusApiClient : IStratusApiClient
{
    private readonly HttpClient _http;
    private readonly StratusApiConfig _config;
    private readonly ILogger<StratusApiClient> _logger;

    public StratusApiClient(HttpClient http, StratusApiConfig config, ILogger<StratusApiClient> logger)
    {
        _http = http;
        _config = config;
        _logger = logger;
    }

    // ────────────────────── internal helpers ──────────────────────

    private HttpRequestMessage BuildRequest(HttpMethod method, string relativeUrl, HttpContent? content = null)
    {
        var req = new HttpRequestMessage(method, relativeUrl);
        if (content is not null)
            req.Content = content;
        req.Headers.Add("x-api-key", _config.ApiKey);
        req.Headers.Add("X-Correlation-Id", Guid.NewGuid().ToString());
        return req;
    }

    private async Task<T> SendWithRetryAsync<T>(Func<HttpRequestMessage> requestFactory, CancellationToken ct)
    {
        Exception? last = null;
        for (int attempt = 0; attempt <= _config.MaxRetries; attempt++)
        {
            var request = requestFactory();
            try
            {
                var response = await _http.SendAsync(request, ct);
                response.EnsureSuccessStatusCode();
                var result = await response.Content.ReadFromJsonAsync<T>(cancellationToken: ct);
                return result!;
            }
            catch (HttpRequestException ex) when (attempt < _config.MaxRetries)
            {
                last = ex;
                _logger.LogWarning("Attempt {Attempt} failed: {Message}. Retrying...", attempt + 1, ex.Message);
                await Task.Delay(TimeSpan.FromSeconds(Math.Pow(2, attempt)), ct);
            }
        }
        throw last!;
    }

    private async Task SendWithRetryAsync(Func<HttpRequestMessage> requestFactory, CancellationToken ct)
    {
        Exception? last = null;
        for (int attempt = 0; attempt <= _config.MaxRetries; attempt++)
        {
            var request = requestFactory();
            try
            {
                var response = await _http.SendAsync(request, ct);
                response.EnsureSuccessStatusCode();
                return;
            }
            catch (HttpRequestException ex) when (attempt < _config.MaxRetries)
            {
                last = ex;
                _logger.LogWarning("Attempt {Attempt} failed: {Message}. Retrying...", attempt + 1, ex.Message);
                await Task.Delay(TimeSpan.FromSeconds(Math.Pow(2, attempt)), ct);
            }
        }
        throw last!;
    }

    // ────────────────────── Company ──────────────────────

    public async Task<IReadOnlyList<TrackingStatusDto>> GetTrackingStatusesAsync(CancellationToken ct = default)
    {
        var result = await SendWithRetryAsync<List<TrackingStatusDto>>(
            () => BuildRequest(HttpMethod.Get, "company/trackingstatuses"),
            ct);
        return result?.AsReadOnly() ?? (IReadOnlyList<TrackingStatusDto>)Array.Empty<TrackingStatusDto>();
    }

    public async Task<IReadOnlyList<FieldDto>> GetCompanyFieldsAsync(CancellationToken ct = default)
    {
        var result = await SendWithRetryAsync<List<FieldDto>>(
            () => BuildRequest(HttpMethod.Get, "company/fields"),
            ct);
        return result?.AsReadOnly() ?? (IReadOnlyList<FieldDto>)Array.Empty<FieldDto>();
    }

    // ────────────────────── Part – Read ──────────────────────

    public async Task<PartDto?> GetPartAsync(string partId, bool includeStratusProperties = false, CancellationToken ct = default)
    {
        try
        {
            var qs = includeStratusProperties ? "?includeStratusProperties=true" : "";
            return await SendWithRetryAsync<PartDto>(
                () => BuildRequest(HttpMethod.Get, $"v2/part/{partId}{qs}"),
                ct);
        }
#if NET5_0_OR_GREATER
        catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return null;
        }
#else
        catch (HttpRequestException)
        {
            return null;
        }
#endif
    }

    public async Task<PartDto?> GetPartByQrCodeAsync(string qrCode, CancellationToken ct = default)
    {
        try
        {
            return await SendWithRetryAsync<PartDto>(
                () => BuildRequest(HttpMethod.Get, $"v1/part/{Uri.EscapeDataString(qrCode)}"),
                ct);
        }
#if NET5_0_OR_GREATER
        catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return null;
        }
#else
        catch (HttpRequestException)
        {
            return null;
        }
#endif
    }

    public async Task<PagedResponse<PartDto>> GetPartsAsync(int pageOffset = 0, int pageLimit = 50, CancellationToken ct = default)
    {
        return await SendWithRetryAsync<PagedResponse<PartDto>>(
            () => BuildRequest(HttpMethod.Get, $"v1/part?pageOffset={pageOffset}&pageLimit={pageLimit}"),
            ct);
    }

    // ────────────────────── Part – Tracking Status ──────────────────────

    public async Task<TrackingStatusUpdateResponse> UpdatePartTrackingStatusAsync(
        string partId, TrackingStatusUpdateRequest request, bool isCut = true, CancellationToken ct = default)
    {
        var query = isCut ? "" : "?isCut=false";
        return await SendWithRetryAsync<TrackingStatusUpdateResponse>(
            () => BuildRequest(HttpMethod.Post, $"v1/part/{partId}/tracking-status{query}",
                JsonContent.Create(request)),
            ct);
    }

    // ────────────────────── Part – Properties ──────────────────────

    public async Task<FieldValuePair> UpdatePartPropertyAsync(string partId, string key, string value, CancellationToken ct = default)
    {
        return await SendWithRetryAsync<FieldValuePair>(
            () => BuildRequest(new HttpMethod("PATCH"), $"v1/part/{partId}/property",
                JsonContent.Create(new FieldValuePair { Key = key, Value = value })),
            ct);
    }

    public async Task UpdatePartPropertiesBulkAsync(IReadOnlyList<BulkPropertyUpdate> updates, CancellationToken ct = default)
    {
        await SendWithRetryAsync(
            () => BuildRequest(new HttpMethod("PATCH"), "v1/part/properties",
                JsonContent.Create(updates)),
            ct);
    }

    // ────────────────────── Part – Company Fields (v2) ──────────────────────

    public async Task UpdatePartFieldAsync(string partId, string fieldId, string? value, CancellationToken ct = default)
    {
        await SendWithRetryAsync(
            () => BuildRequest(new HttpMethod("PATCH"), $"v2/part/{partId}/field",
                JsonContent.Create(new FieldUpdateRequest { FieldId = fieldId, Value = value })),
            ct);
    }

    public async Task UpdatePartFieldsAsync(string partId, FieldsUpdateRequest fields, CancellationToken ct = default)
    {
        await SendWithRetryAsync(
            () => BuildRequest(new HttpMethod("PATCH"), $"v2/part/{partId}/fields",
                JsonContent.Create(fields)),
            ct);
    }
}
