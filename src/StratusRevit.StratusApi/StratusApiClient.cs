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

    public async Task<TrackingStatusUpdateResponse> UpdateAssemblyTrackingStatusAsync(
        string assemblyId, TrackingStatusUpdateRequest request, CancellationToken ct = default)
    {
        return await SendWithRetryAsync<TrackingStatusUpdateResponse>(
            () => BuildRequest(HttpMethod.Post, $"v1/assembly/{assemblyId}/trackingstatus",
                JsonContent.Create(request)),
            ct);
    }

    public async Task UpdateAssemblyFieldAsync(string assemblyId, string fieldId, string value, CancellationToken ct = default)
    {
        await SendWithRetryAsync(
            () => BuildRequest(HttpMethod.Post, $"v1/assembly/{assemblyId}/field",
                JsonContent.Create(new FieldValuePair { Key = fieldId, Value = value })),
            ct);
    }

    public async Task UpdateAssemblyFieldsAsync(string assemblyId, IReadOnlyList<FieldValuePair> fields, CancellationToken ct = default)
    {
        await SendWithRetryAsync(
            () => BuildRequest(HttpMethod.Post, $"v1/assembly/{assemblyId}/fields",
                JsonContent.Create(fields)),
            ct);
    }

    public async Task<AssemblyDto?> GetAssemblyAsync(string assemblyId, CancellationToken ct = default)
    {
        try
        {
            return await SendWithRetryAsync<AssemblyDto>(
                () => BuildRequest(HttpMethod.Get, $"v1/assembly/{assemblyId}"),
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
            // On .NET Framework, HttpRequestException doesn't expose StatusCode.
            return null;
        }
#endif
    }
}
