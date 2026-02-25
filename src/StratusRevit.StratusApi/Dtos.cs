using System.Text.Json.Serialization;

namespace StratusRevit.StratusApi;

// ====================================================================
// Configuration
// ====================================================================

public class StratusApiConfig
{
    public string BaseUrl { get; set; } = "https://api.gtpstratus.com";
    public string ApiKey { get; set; } = "";
    public int TimeoutSeconds { get; set; } = 30;
    public int MaxRetries { get; set; } = 3;
}

// ====================================================================
// Company / Tracking Status
// ====================================================================

public class TrackingStatusDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("trackingStatusGroupId")]
    public string? TrackingStatusGroupId { get; set; }

    [JsonPropertyName("trackingStatusGroupName")]
    public string? TrackingStatusGroupName { get; set; }
}

public class FieldDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    [JsonPropertyName("isEditable")]
    public bool IsEditable { get; set; }

    [JsonPropertyName("isExpression")]
    public bool IsExpression { get; set; }

    [JsonPropertyName("isTotal")]
    public bool IsTotal { get; set; }

    [JsonPropertyName("possibleValues")]
    public string? PossibleValues { get; set; }

    [JsonPropertyName("dataType")]
    public int? DataType { get; set; }

    [JsonPropertyName("dataTypeName")]
    public string? DataTypeName { get; set; }

    [JsonPropertyName("defaultValue")]
    public string? DefaultValue { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("filterId")]
    public string? FilterId { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    [JsonPropertyName("createdDT")]
    public DateTimeOffset? CreatedDT { get; set; }

    [JsonPropertyName("modifiedDT")]
    public DateTimeOffset? ModifiedDT { get; set; }
}

// ====================================================================
// Part – full DTO (GET /v2/part/{id})
// ====================================================================

/// <summary>
/// Represents a Stratus Part as returned by GET /v2/part/{id}.
/// Covers the complete schema from api.gtpstratus.com.
/// </summary>
public class PartDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("createdDT")]
    public DateTimeOffset? CreatedDT { get; set; }

    [JsonPropertyName("modifiedDT")]
    public DateTimeOffset? ModifiedDT { get; set; }

    [JsonPropertyName("cutDT")]
    public DateTimeOffset? CutDT { get; set; }

    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    [JsonPropertyName("projectName")]
    public string? ProjectName { get; set; }

    [JsonPropertyName("projectNumber")]
    public string? ProjectNumber { get; set; }

    [JsonPropertyName("modelId")]
    public string? ModelId { get; set; }

    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    [JsonPropertyName("bimAreaId")]
    public string? BimAreaId { get; set; }

    [JsonPropertyName("bimArea")]
    public string? BimArea { get; set; }

    [JsonPropertyName("cadId")]
    public string? CadId { get; set; }

    [JsonPropertyName("cadType")]
    public string? CadType { get; set; }

    [JsonPropertyName("webId")]
    public string? WebId { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("currentTrackingStatusId")]
    public string? CurrentTrackingStatusId { get; set; }

    [JsonPropertyName("currentDivisionId")]
    public string? CurrentDivisionId { get; set; }

    /// <summary>User-defined properties (key/value).</summary>
    [JsonPropertyName("properties")]
    public Dictionary<string, string?>? Properties { get; set; }

    /// <summary>GTP-internal properties (key/value).</summary>
    [JsonPropertyName("propertiesGtp")]
    public Dictionary<string, string?>? PropertiesGtp { get; set; }

    /// <summary>3-D or location points attached to the part.</summary>
    [JsonPropertyName("points")]
    public List<PartPointDto>? Points { get; set; }

    [JsonPropertyName("cutLengthAdjustment")]
    public double? CutLengthAdjustment { get; set; }

    [JsonPropertyName("cutLength2Adjustment")]
    public double? CutLength2Adjustment { get; set; }

    [JsonPropertyName("lockLength")]
    public bool? LockLength { get; set; }

    [JsonPropertyName("lockLocation")]
    public bool? LockLocation { get; set; }

    [JsonPropertyName("qrCodeUrl")]
    public string? QrCodeUrl { get; set; }

    [JsonPropertyName("partUrl")]
    public string? PartUrl { get; set; }

    [JsonPropertyName("patternNumber")]
    public string? PatternNumber { get; set; }

    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Company-level field values keyed by Field ID.</summary>
    [JsonPropertyName("fieldIdToValueMap")]
    public Dictionary<string, string?>? FieldIdToValueMap { get; set; }

    /// <summary>Company-level field values keyed by Field Name.</summary>
    [JsonPropertyName("fieldNameToValueMap")]
    public Dictionary<string, string?>? FieldNameToValueMap { get; set; }
}

/// <summary>A 3-D point attached to a Part.</summary>
public class PartPointDto
{
    [JsonPropertyName("pointType")]
    public string? PointType { get; set; }

    [JsonPropertyName("cadId")]
    public string? CadId { get; set; }

    [JsonPropertyName("location")]
    public Point3DDto? Location { get; set; }

    [JsonPropertyName("direction")]
    public Point3DDto? Direction { get; set; }

    [JsonPropertyName("upVector")]
    public Point3DDto? UpVector { get; set; }

    [JsonPropertyName("width")]
    public double? Width { get; set; }

    [JsonPropertyName("height")]
    public double? Height { get; set; }

    [JsonPropertyName("matingElementUniqueId")]
    public string? MatingElementUniqueId { get; set; }
}

public class Point3DDto
{
    [JsonPropertyName("x")]
    public double X { get; set; }

    [JsonPropertyName("y")]
    public double Y { get; set; }

    [JsonPropertyName("z")]
    public double Z { get; set; }
}

// ====================================================================
// Part – Tracking Status (POST /v1/part/{id}/tracking-status)
// ====================================================================

public class TrackingStatusUpdateRequest
{
    [JsonPropertyName("trackingStatusId")]
    public string TrackingStatusId { get; set; } = "";

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("divisionId")]
    public string? DivisionId { get; set; }

    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    [JsonPropertyName("costTypeId")]
    public string? CostTypeId { get; set; }

    [JsonPropertyName("createdDT")]
    public DateTimeOffset? CreatedDT { get; set; }
}

public class TrackingStatusUpdateResponse
{
    [JsonPropertyName("trackingStatusId")]
    public string? TrackingStatusId { get; set; }

    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    [JsonPropertyName("divisionId")]
    public string? DivisionId { get; set; }

    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    [JsonPropertyName("costTypeId")]
    public string? CostTypeId { get; set; }

    [JsonPropertyName("createdDT")]
    public DateTimeOffset? CreatedDT { get; set; }

    [JsonPropertyName("trackingLogEntryIdResult")]
    public string? TrackingLogEntryIdResult { get; set; }
}

// ====================================================================
// Part – Single property (PATCH /v1/part/{id}/property)
// ====================================================================

public class FieldValuePair
{
    [JsonPropertyName("key")]
    public string Key { get; set; } = "";

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

// ====================================================================
// Part – Bulk properties (PATCH /v1/part/properties)
// ====================================================================

/// <summary>
/// Request body for PATCH /v1/part/properties.
/// Array of up to 1 000 property changes.
/// </summary>
public class BulkPropertyUpdate
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("properties")]
    public Dictionary<string, string?> Properties { get; set; } = new();
}

// ====================================================================
// Part – Company field update (PATCH /v2/part/{id}/field)
// Uses FieldValuePair (same {"key":"...","value":"..."} shape)
// PATCH /v2/part/{id}/fields uses an array of FieldValuePair
// ====================================================================

// ====================================================================
// Paging wrapper
// ====================================================================

public class PagedResponse<T>
{
    [JsonPropertyName("data")]
    public List<T> Data { get; set; } = new();

    [JsonPropertyName("pageOffset")]
    public int PageOffset { get; set; }

    [JsonPropertyName("pageLimit")]
    public int PageLimit { get; set; }

    [JsonPropertyName("pageCount")]
    public int PageCount { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("truncatedResults")]
    public bool TruncatedResults { get; set; }
}
