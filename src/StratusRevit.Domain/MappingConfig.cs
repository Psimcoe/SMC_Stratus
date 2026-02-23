using System.Text.Json.Serialization;

namespace StratusRevit.Domain;

public class MappingConfig
{
    [JsonPropertyName("version")]
    public int Version { get; set; } = 1;

    [JsonPropertyName("conflictPolicy")]
    public ConflictPolicy ConflictPolicy { get; set; } = ConflictPolicy.RevitWins;

    [JsonPropertyName("fieldMappings")]
    public List<FieldMappingRule> FieldMappings { get; set; } = new();
}

public enum ConflictPolicy
{
    RevitWins,
    StratusWins,
    DoNotChange
}

public class FieldMappingRule
{
    [JsonPropertyName("revitParameter")]
    public string RevitParameter { get; set; } = "";

    [JsonPropertyName("stratusField")]
    public string StratusField { get; set; } = "";

    [JsonPropertyName("isTrackingStatus")]
    public bool IsTrackingStatus { get; set; }

    [JsonPropertyName("normalization")]
    public NormalizationRule? Normalization { get; set; }

    [JsonPropertyName("conflictPolicy")]
    public ConflictPolicy? ConflictPolicyOverride { get; set; }

    [JsonPropertyName("allowOverwriteNonEmpty")]
    public bool AllowOverwriteNonEmpty { get; set; }
}

public class NormalizationRule
{
    [JsonPropertyName("trim")]
    public bool Trim { get; set; } = true;

    [JsonPropertyName("toLower")]
    public bool ToLower { get; set; }

    [JsonPropertyName("toUpper")]
    public bool ToUpper { get; set; }
}
