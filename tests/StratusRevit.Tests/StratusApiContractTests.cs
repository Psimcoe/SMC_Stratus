using System.Net;
using System.Text.Json;
using Microsoft.Extensions.Logging.Abstractions;
using StratusRevit.StratusApi;

namespace StratusRevit.Tests;

public class StratusApiContractTests
{
    private static StratusApiClient CreateClient(HttpMessageHandler handler)
    {
        var httpClient = new HttpClient(handler) { BaseAddress = new Uri("https://api.gtpstratus.com/") };
        var config = new StratusApiConfig { ApiKey = "test-key", MaxRetries = 0 };
        return new StratusApiClient(httpClient, config, NullLogger<StratusApiClient>.Instance);
    }

    [Fact]
    public async Task GetTrackingStatuses_DeserializesCorrectly()
    {
        var json = JsonSerializer.Serialize(new[]
        {
            new { id = "ts-1", name = "Fabricating", trackingStatusGroupId = "g-1", trackingStatusGroupName = "Production" }
        });
        var handler = new MockHttpHandler(HttpStatusCode.OK, json);
        var client = CreateClient(handler);
        var result = await client.GetTrackingStatusesAsync();
        Assert.Single(result);
        Assert.Equal("ts-1", result[0].Id);
        Assert.Equal("Fabricating", result[0].Name);
    }

    [Fact]
    public async Task GetCompanyFields_DeserializesCorrectly()
    {
        var json = JsonSerializer.Serialize(new[]
        {
            new { id = "f-1", name = "Comments", displayName = "Comments", isEditable = true }
        });
        var handler = new MockHttpHandler(HttpStatusCode.OK, json);
        var client = CreateClient(handler);
        var result = await client.GetCompanyFieldsAsync();
        Assert.Single(result);
        Assert.True(result[0].IsEditable);
        Assert.Equal("Comments", result[0].Name);
    }

    [Fact]
    public async Task UpdatePartTrackingStatus_SendsCorrectRequest()
    {
        var responseJson = JsonSerializer.Serialize(new { trackingStatusId = "ts-1", trackingLogEntryIdResult = "log-1" });
        var handler = new MockHttpHandler(HttpStatusCode.OK, responseJson);
        var client = CreateClient(handler);
        var req = new TrackingStatusUpdateRequest { TrackingStatusId = "ts-1" };
        var response = await client.UpdatePartTrackingStatusAsync("part-123", req);
        Assert.Equal("log-1", response.TrackingLogEntryIdResult);
    }

    [Fact]
    public async Task GetPart_NotFound_ReturnsNull()
    {
        var handler = new MockHttpHandler(HttpStatusCode.NotFound, "");
        var client = CreateClient(handler);
        var result = await client.GetPartAsync("missing-id");
        Assert.Null(result);
    }

    [Fact]
    public async Task GetPart_DeserializesFullDto()
    {
        var json = JsonSerializer.Serialize(new
        {
            id = "part-1",
            projectName = "Test Project",
            cadId = "cad-123",
            currentTrackingStatusId = "ts-1",
            properties = new Dictionary<string, string> { ["key1"] = "val1" },
            fieldNameToValueMap = new Dictionary<string, string> { ["Comments"] = "hello" },
            qrCodeUrl = "http://gtp.one/ABC"
        });
        var handler = new MockHttpHandler(HttpStatusCode.OK, json);
        var client = CreateClient(handler);
        var result = await client.GetPartAsync("part-1");
        Assert.NotNull(result);
        Assert.Equal("part-1", result!.Id);
        Assert.Equal("Test Project", result.ProjectName);
        Assert.Equal("cad-123", result.CadId);
        Assert.NotNull(result.Properties);
        Assert.Equal("val1", result.Properties!["key1"]);
        Assert.Equal("http://gtp.one/ABC", result.QrCodeUrl);
    }

    [Fact]
    public async Task GetPartByQrCode_ReturnsPartDto()
    {
        var json = JsonSerializer.Serialize(new { id = "part-qr-1", cadId = "c1" });
        var handler = new MockHttpHandler(HttpStatusCode.OK, json);
        var client = CreateClient(handler);
        var result = await client.GetPartByQrCodeAsync("http://gtp.one/XYZ");
        Assert.NotNull(result);
        Assert.Equal("part-qr-1", result!.Id);
    }

    [Fact]
    public async Task UpdatePartPropertiesBulk_SendsWithoutException()
    {
        var handler = new MockHttpHandler(HttpStatusCode.OK, "");
        var client = CreateClient(handler);
        var updates = new List<BulkPropertyUpdate>
        {
            new() { Id = "p1", Properties = new Dictionary<string, string?> { ["k"] = "v" } }
        };
        var ex = await Record.ExceptionAsync(() => client.UpdatePartPropertiesBulkAsync(updates));
        Assert.Null(ex);
    }

    [Fact]
    public async Task UpdatePartField_SendsWithoutException()
    {
        var handler = new MockHttpHandler(HttpStatusCode.OK, "");
        var client = CreateClient(handler);
        var ex = await Record.ExceptionAsync(() => client.UpdatePartFieldAsync("part-1", "field-id", "new-value"));
        Assert.Null(ex);
    }
}

public class MockHttpHandler : HttpMessageHandler
{
    private readonly HttpStatusCode _statusCode;
    private readonly string _content;

    public MockHttpHandler(HttpStatusCode statusCode, string content)
    {
        _statusCode = statusCode;
        _content = content;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = new HttpResponseMessage(_statusCode)
        {
            Content = new StringContent(_content, System.Text.Encoding.UTF8, "application/json")
        };
        return Task.FromResult(response);
    }
}
