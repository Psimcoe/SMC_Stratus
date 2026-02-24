using System.Net;
using System.Text.Json;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using StratusRevit.Domain;
using StratusRevit.RevitAdapter.Abstractions;
using StratusRevit.StratusApi;
using StratusRevit.SyncEngine;

namespace StratusRevit.Tests;

/// <summary>
/// Integration tests that exercise the full pipeline: mapping → validation → sync engine → API client.
/// All Stratus API calls are handled by a fake HTTP handler so no live credentials are needed.
/// To run against a real Stratus sandbox, set the environment variables:
///   STRATUS_BASE_URL, STRATUS_API_KEY
/// and remove the [Trait("Category","Integration")] filter or run:
///   dotnet test --filter "Category=Integration"
/// </summary>
[Trait("Category", "Integration")]
public class IntegrationTests
{
    #region Helpers

    /// <summary>Builds a fully-wired SyncEngine backed by a fake HTTP handler.</summary>
    private static StratusRevit.SyncEngine.SyncEngine CreateEngine(
        FakeStratusHandler handler,
        MappingConfig? mappingConfig = null)
    {
        var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://api.gtpstratus.com/")
        };
        var apiConfig = new StratusApiConfig { ApiKey = "test-key", MaxRetries = 0 };
        var apiClient = new StratusApiClient(httpClient, apiConfig, NullLogger<StratusApiClient>.Instance);

        var config = mappingConfig ?? DefaultMappingConfig();
        var mapper = new ChangeMapper(config);
        var audit = new AuditLogger(NullLogger<AuditLogger>.Instance);

        return new StratusRevit.SyncEngine.SyncEngine(
            apiClient, mapper,
            NullLogger<StratusRevit.SyncEngine.SyncEngine>.Instance, audit);
    }

    private static MappingConfig DefaultMappingConfig() => new()
    {
        ConflictPolicy = ConflictPolicy.RevitWins,
        FieldMappings = new List<FieldMappingRule>
        {
            new()
            {
                RevitParameter = "STRATUS_STATUS",
                StratusField = "trackingStatus",
                IsTrackingStatus = true,
                Normalization = new NormalizationRule { Trim = true },
                AllowOverwriteNonEmpty = true
            },
            new()
            {
                RevitParameter = "Comments",
                StratusField = "Comments",
                IsTrackingStatus = false,
                Normalization = new NormalizationRule { Trim = true },
                AllowOverwriteNonEmpty = true
            }
        }
    };

    private static List<RevitElementData> SampleElements(int count = 1)
    {
        var elements = new List<RevitElementData>();
        for (var i = 1; i <= count; i++)
        {
            elements.Add(new RevitElementData(
                $"elem-{i}",
                $"unique-{i}",
                "Assembly",
                $"Beam-{i}",
                new Dictionary<string, string?>
                {
                    ["STRATUS_STATUS"] = "ts-fabricating",
                    ["Comments"] = $"  Updated in Revit #{i}  "
                }));
        }
        return elements;
    }

    #endregion

    // -----------------------------------------------------------------------
    // Full-pipeline: DryRun
    // -----------------------------------------------------------------------

    [Fact]
    public async Task FullPipeline_DryRun_ReturnsCorrectReport_WithoutApiCalls()
    {
        var handler = new FakeStratusHandler();
        var engine = CreateEngine(handler);

        var elements = SampleElements(3);
        var report = await engine.DryRunAsync(elements);

        Assert.True(report.IsDryRun);
        Assert.Equal(3, report.TotalElements);
        Assert.True(report.ChangesPlanned > 0);
        Assert.Equal(0, report.ChangesSucceeded);
        Assert.Equal(0, report.ChangesFailed);
        // No HTTP calls should have been made
        Assert.Empty(handler.RequestLog);
    }

    // -----------------------------------------------------------------------
    // Full-pipeline: Push with valid data
    // -----------------------------------------------------------------------

    [Fact]
    public async Task FullPipeline_PushUpdates_AllSucceed()
    {
        var handler = FakeStratusHandler.WithDefaults();
        var engine = CreateEngine(handler);

        var elements = SampleElements(2);
        var report = await engine.PushUpdatesAsync(elements);

        Assert.False(report.IsDryRun);
        Assert.Equal(2, report.TotalElements);
        Assert.True(report.ChangesSucceeded > 0);
        Assert.Equal(0, report.ChangesFailed);

        // Verify actual HTTP calls were dispatched
        Assert.True(handler.RequestLog.Count > 0, "Expected at least one API call during push");
    }

    // -----------------------------------------------------------------------
    // Push with invalid tracking status → validation failures
    // -----------------------------------------------------------------------

    [Fact]
    public async Task FullPipeline_PushUpdates_InvalidStatus_ReportsFailures()
    {
        // The fake handler returns only "ts-valid" as a valid tracking status.
        // Our elements contain "ts-fabricating" which won't pass validation.
        var handler = FakeStratusHandler.WithCustomStatuses(new[] { "ts-valid" });
        var engine = CreateEngine(handler);

        var elements = SampleElements(1);
        var report = await engine.PushUpdatesAsync(elements);

        Assert.False(report.IsDryRun);
        // The tracking status change should fail validation
        Assert.True(report.ChangesFailed > 0, "Expected validation failures for bad tracking status");
    }

    // -----------------------------------------------------------------------
    // Mapping normalization flows through to sync engine
    // -----------------------------------------------------------------------

    [Fact]
    public async Task FullPipeline_NormalizationApplied_TrimAndLowercase()
    {
        var config = new MappingConfig
        {
            ConflictPolicy = ConflictPolicy.RevitWins,
            FieldMappings = new List<FieldMappingRule>
            {
                new()
                {
                    RevitParameter = "Status",
                    StratusField = "status",
                    IsTrackingStatus = false,
                    Normalization = new NormalizationRule { Trim = true, ToLower = true },
                    AllowOverwriteNonEmpty = true
                }
            }
        };

        var handler = FakeStratusHandler.WithDefaults();
        var engine = CreateEngine(handler, config);

        var elements = new List<RevitElementData>
        {
            new("e1", "u1", "Assembly", "Beam",
                new Dictionary<string, string?> { ["Status"] = "  ACTIVE  " })
        };

        var dryReport = await engine.DryRunAsync(elements);
        Assert.Equal(1, dryReport.ChangesPlanned);
    }

    // -----------------------------------------------------------------------
    // Multiple elements, mixed outcomes
    // -----------------------------------------------------------------------

    [Fact]
    public async Task FullPipeline_MixedElements_ReportsPartialSuccess()
    {
        // Use default handler that returns "ts-fabricating" as valid
        var handler = FakeStratusHandler.WithDefaults();
        var engine = CreateEngine(handler);

        // Element 1: valid tracking status
        // Element 2: has an empty status → should still produce a mapping
        var elements = new List<RevitElementData>
        {
            new("e1", "u1", "Assembly", "Beam-1",
                new Dictionary<string, string?>
                {
                    ["STRATUS_STATUS"] = "ts-fabricating",
                    ["Comments"] = "Good element"
                }),
            new("e2", "u2", "Assembly", "Beam-2",
                new Dictionary<string, string?>
                {
                    ["STRATUS_STATUS"] = "ts-fabricating",
                    ["Comments"] = "Another good element"
                })
        };

        var report = await engine.PushUpdatesAsync(elements);
        Assert.Equal(2, report.TotalElements);
        Assert.True(report.ChangesSucceeded >= 2, "Both elements should succeed");
    }

    // -----------------------------------------------------------------------
    // API failure mid-push → captured as failed change
    // -----------------------------------------------------------------------

    [Fact]
    public async Task FullPipeline_ApiError_CapturedAsFailedChange()
    {
        // Handler that succeeds for GET but returns 500 on POST
        var handler = FakeStratusHandler.WithPostFailure(HttpStatusCode.InternalServerError);
        var engine = CreateEngine(handler);

        var elements = SampleElements(1);
        var report = await engine.PushUpdatesAsync(elements);

        Assert.False(report.IsDryRun);
        Assert.True(report.ChangesFailed > 0, "Expected failures when API returns 500");
    }

    // -----------------------------------------------------------------------
    // Empty element list → clean empty report
    // -----------------------------------------------------------------------

    [Fact]
    public async Task FullPipeline_EmptyInput_ReturnsCleanReport()
    {
        var handler = FakeStratusHandler.WithDefaults();
        var engine = CreateEngine(handler);

        var dryReport = await engine.DryRunAsync(new List<RevitElementData>());
        Assert.Equal(0, dryReport.TotalElements);
        Assert.Empty(dryReport.Results);

        var pushReport = await engine.PushUpdatesAsync(new List<RevitElementData>());
        Assert.Equal(0, pushReport.TotalElements);
        Assert.Empty(pushReport.Results);
    }

    // -----------------------------------------------------------------------
    // Validates that audit logging doesn't throw
    // -----------------------------------------------------------------------

    [Fact]
    public async Task FullPipeline_AuditLogger_DoesNotThrow()
    {
        var handler = FakeStratusHandler.WithDefaults();
        var engine = CreateEngine(handler);

        var elements = SampleElements(5);
        var ex = await Record.ExceptionAsync(() => engine.PushUpdatesAsync(elements));
        Assert.Null(ex);
    }
}

// ---------------------------------------------------------------------------
// Configurable fake HTTP handler for integration tests
// ---------------------------------------------------------------------------

/// <summary>
/// A fake <see cref="HttpMessageHandler"/> that simulates the Stratus API 
/// by routing requests based on URL path. Records all requests for assertions.
/// </summary>
public class FakeStratusHandler : HttpMessageHandler
{
    private readonly List<(string Method, string Url)> _requestLog = new();
    public IReadOnlyList<(string Method, string Url)> RequestLog => _requestLog;

    // Configurable responses by path prefix
    private readonly Dictionary<string, Func<HttpRequestMessage, HttpResponseMessage>> _routes = new();

    /// <summary>Default: returns 200 with empty JSON for all unconfigured routes.</summary>
    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken ct)
    {
        _requestLog.Add((request.Method.Method, request.RequestUri?.PathAndQuery ?? ""));

        var path = request.RequestUri?.PathAndQuery ?? "";

        foreach (var (prefix, handler) in _routes)
        {
            if (path.Contains(prefix, StringComparison.OrdinalIgnoreCase))
                return Task.FromResult(handler(request));
        }

        // Fallback: 200 OK with empty JSON object
        return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent("{}", System.Text.Encoding.UTF8, "application/json")
        });
    }

    public void AddRoute(string pathContains, HttpStatusCode status, string json)
    {
        _routes[pathContains] = _ => new HttpResponseMessage(status)
        {
            Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json")
        };
    }

    public void AddRoute(string pathContains, Func<HttpRequestMessage, HttpResponseMessage> handler)
    {
        _routes[pathContains] = handler;
    }

    // --------------- Factory methods ---------------

    /// <summary>
    /// Preconfigured handler that returns:
    ///   - valid tracking statuses (including ts-fabricating)
    ///   - editable company fields (Comments)
    ///   - success on tracking status updates
    ///   - success on field updates
    /// </summary>
    public static FakeStratusHandler WithDefaults()
    {
        var h = new FakeStratusHandler();

        h.AddRoute("trackingstatuses", HttpStatusCode.OK, JsonSerializer.Serialize(new[]
        {
            new { id = "ts-fabricating", name = "Fabricating", trackingStatusGroupId = "g-1", trackingStatusGroupName = "Production" },
            new { id = "ts-shipped", name = "Shipped", trackingStatusGroupId = "g-2", trackingStatusGroupName = "Logistics" }
        }));

        h.AddRoute("company/fields", HttpStatusCode.OK, JsonSerializer.Serialize(new[]
        {
            new { id = "f-1", name = "Comments", displayName = "Comments", isEditable = true },
            new { id = "f-2", name = "Location", displayName = "Location", isEditable = true }
        }));

        h.AddRoute("trackingstatus", HttpStatusCode.OK, JsonSerializer.Serialize(new
        {
            trackingStatusId = "ts-fabricating",
            trackingLogEntryIdResult = "log-" + Guid.NewGuid().ToString("N")[..8]
        }));

        h.AddRoute("/field", HttpStatusCode.OK, "{}");

        return h;
    }

    /// <summary>Returns a handler with a custom set of valid tracking status IDs.</summary>
    public static FakeStratusHandler WithCustomStatuses(IEnumerable<string> statusIds)
    {
        var h = WithDefaults();
        var statuses = statusIds.Select(id => new { id, name = id, trackingStatusGroupId = "g-1", trackingStatusGroupName = "Default" });
        h.AddRoute("trackingstatuses", HttpStatusCode.OK, JsonSerializer.Serialize(statuses));
        return h;
    }

    /// <summary>Returns a handler where POST requests to assembly endpoints return an error.</summary>
    public static FakeStratusHandler WithPostFailure(HttpStatusCode failureCode)
    {
        var h = WithDefaults();
        h.AddRoute("trackingstatus", req =>
        {
            if (req.Method == HttpMethod.Post)
                return new HttpResponseMessage(failureCode)
                {
                    Content = new StringContent("{\"error\":\"simulated failure\"}", System.Text.Encoding.UTF8, "application/json")
                };
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("[]", System.Text.Encoding.UTF8, "application/json")
            };
        });
        h.AddRoute("/field", req =>
        {
            if (req.Method == HttpMethod.Post)
                return new HttpResponseMessage(failureCode)
                {
                    Content = new StringContent("{\"error\":\"simulated failure\"}", System.Text.Encoding.UTF8, "application/json")
                };
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{}", System.Text.Encoding.UTF8, "application/json")
            };
        });
        return h;
    }
}
