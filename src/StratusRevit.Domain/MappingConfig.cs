using System.Text.Json.Serialization;

namespace StratusRevit.Domain;

public class MappingConfig
{
    [JsonPropertyName("version")]
    public int Version { get; set; } = 1;

    [JsonPropertyName("conflictPolicy")]
    public ConflictPolicy ConflictPolicy { get; set; } = ConflictPolicy.RevitWins;

    /// <summary>
    /// Name of the Revit parameter that contains the Stratus Part ID (GUID).
    /// If null, falls back to the Revit element UniqueId – which will only work
    /// when the CadId in Stratus matches the Revit UniqueId.
    /// Common values: "STRATUS Item Number", "STRATUS_PART_ID", etc.
    /// </summary>
    [JsonPropertyName("stratusIdParameter")]
    public string? StratusIdParameter { get; set; }

    /// <summary>
    /// When set, the value of this Revit parameter is treated as a Stratus
    /// QR-code value and resolved via GET /v1/part/{qrCode} to obtain the
    /// real Part ID. Takes precedence over <see cref="StratusIdParameter"/>.
    /// </summary>
    [JsonPropertyName("stratusQrCodeParameter")]
    public string? StratusQrCodeParameter { get; set; }

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

    /// <summary>
    /// When true the target is a company-level Field (PATCH /v2/part/{id}/field)
    /// instead of a user-defined Property (PATCH /v1/part/{id}/property).
    /// Requires <see cref="CompanyFieldId"/> to be set.
    /// </summary>
    [JsonPropertyName("isCompanyField")]
    public bool IsCompanyField { get; set; }

    /// <summary>
    /// The Stratus company-field GUID. Required when <see cref="IsCompanyField"/> is true.
    /// Obtain from GET /company/fields.
    /// </summary>
    [JsonPropertyName("companyFieldId")]
    public string? CompanyFieldId { get; set; }

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
