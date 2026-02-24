using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using StratusRevit.Domain;
using StratusRevit.RevitAdapter.Abstractions;
using StratusRevit.StratusApi;
using StratusRevit.SyncEngine;

namespace StratusRevit.Tests;

public class SyncEngineTests
{
    private static StratusRevit.SyncEngine.SyncEngine CreateEngine(IStratusApiClient? apiClient = null)
    {
        var config = new MappingConfig
        {
            FieldMappings = new List<FieldMappingRule>
            {
                new()
                {
                    RevitParameter = "STRATUS_STATUS",
                    StratusField = "trackingStatus",
                    IsTrackingStatus = true,
                    AllowOverwriteNonEmpty = true
                }
            }
        };
        var mapper = new ChangeMapper(config);
        var audit = new AuditLogger(NullLogger<AuditLogger>.Instance);
        var client = apiClient ?? Mock.Of<IStratusApiClient>();
        return new StratusRevit.SyncEngine.SyncEngine(client, mapper, NullLogger<StratusRevit.SyncEngine.SyncEngine>.Instance, audit);
    }

    [Fact]
    public async Task DryRun_DoesNotCallApi()
    {
        var mockApi = new Mock<IStratusApiClient>();
        var engine = CreateEngine(mockApi.Object);

        var elements = new List<RevitElementData>
        {
            new("e1", "u1", "Assembly", "Beam",
                new Dictionary<string, string?> { ["STRATUS_STATUS"] = "ts-001" })
        };

        var report = await engine.DryRunAsync(elements);

        Assert.True(report.IsDryRun);
        Assert.Equal(1, report.TotalElements);
        mockApi.Verify(x => x.UpdatePartTrackingStatusAsync(It.IsAny<string>(), It.IsAny<TrackingStatusUpdateRequest>(), It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DryRun_EmptyElements_ReturnsEmptyReport()
    {
        var engine = CreateEngine();
        var report = await engine.DryRunAsync(new List<RevitElementData>());
        Assert.Equal(0, report.TotalElements);
        Assert.Equal(0, report.ChangesPlanned);
    }

    [Fact]
    public async Task DryRun_WithElements_CountsChanges()
    {
        var engine = CreateEngine();
        var elements = new List<RevitElementData>
        {
            new("e1", "u1", "Assembly", null,
                new Dictionary<string, string?> { ["STRATUS_STATUS"] = "ts-001" }),
            new("e2", "u2", "Assembly", null,
                new Dictionary<string, string?> { ["STRATUS_STATUS"] = "ts-002" })
        };
        var report = await engine.DryRunAsync(elements);
        Assert.Equal(2, report.TotalElements);
        Assert.Equal(2, report.ChangesPlanned);
    }
}
