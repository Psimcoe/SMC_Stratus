using StratusRevit.Domain;
using StratusRevit.RevitAdapter.Abstractions;

namespace StratusRevit.Tests;

public class MappingTests
{
    private static MappingConfig BasicConfig() => new()
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
                AllowOverwriteNonEmpty = false
            }
        }
    };

    [Fact]
    public void Map_MapsTrackingStatusField()
    {
        var mapper = new ChangeMapper(BasicConfig());
        var elements = new List<RevitElementData>
        {
            new("elem1", "unique-1", "Assembly", "Beam-1",
                new Dictionary<string, string?> { ["STRATUS_STATUS"] = " status-id-123 " })
        };
        var intents = mapper.Map(elements, "Assembly", new Dictionary<string, string?>());
        Assert.Single(intents);
        Assert.NotNull(intents[0].TrackingStatusChange);
        Assert.Equal("status-id-123", intents[0].TrackingStatusChange!.NewValue);
    }

    [Fact]
    public void Map_AppliesTrimNormalization()
    {
        var mapper = new ChangeMapper(BasicConfig());
        var elements = new List<RevitElementData>
        {
            new("elem1", "unique-1", "Assembly", "Beam-1",
                new Dictionary<string, string?> { ["Comments"] = "  hello  " })
        };
        var intents = mapper.Map(elements, "Assembly", new Dictionary<string, string?>());
        Assert.Single(intents);
        Assert.Single(intents[0].CustomFieldChanges);
        Assert.Equal("hello", intents[0].CustomFieldChanges[0].NewValue);
    }

    [Fact]
    public void Map_RespectsAllowOverwriteNonEmpty_WhenFalse()
    {
        var mapper = new ChangeMapper(BasicConfig());
        var elements = new List<RevitElementData>
        {
            new("elem1", "unique-1", "Assembly", "Beam-1",
                new Dictionary<string, string?> { ["Comments"] = "new value" })
        };
        var currentValues = new Dictionary<string, string?> { ["Comments"] = "existing" };
        var intents = mapper.Map(elements, "Assembly", currentValues);
        Assert.Empty(intents[0].CustomFieldChanges);
    }

    [Fact]
    public void Map_RespectsConflictPolicy_StratusWins()
    {
        var config = new MappingConfig
        {
            ConflictPolicy = ConflictPolicy.StratusWins,
            FieldMappings = new List<FieldMappingRule>
            {
                new() { RevitParameter = "Comments", StratusField = "Comments", AllowOverwriteNonEmpty = true }
            }
        };
        var mapper = new ChangeMapper(config);
        var elements = new List<RevitElementData>
        {
            new("elem1", "unique-1", "Assembly", null,
                new Dictionary<string, string?> { ["Comments"] = "revit value" })
        };
        var currentValues = new Dictionary<string, string?> { ["Comments"] = "stratus value" };
        var intents = mapper.Map(elements, "Assembly", currentValues);
        Assert.Empty(intents[0].CustomFieldChanges);
    }

    [Fact]
    public void Map_AppliesLowerNormalization()
    {
        var config = new MappingConfig
        {
            FieldMappings = new List<FieldMappingRule>
            {
                new()
                {
                    RevitParameter = "Status",
                    StratusField = "status",
                    Normalization = new NormalizationRule { Trim = true, ToLower = true },
                    AllowOverwriteNonEmpty = true
                }
            }
        };
        var mapper = new ChangeMapper(config);
        var elements = new List<RevitElementData>
        {
            new("e1", "u1", "Assembly", null,
                new Dictionary<string, string?> { ["Status"] = "ACTIVE" })
        };
        var intents = mapper.Map(elements, "Assembly", new Dictionary<string, string?>());
        Assert.Equal("active", intents[0].CustomFieldChanges[0].NewValue);
    }
}
