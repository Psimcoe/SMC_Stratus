using System.Text.Json.Serialization;

namespace StratusRevit.StratusApi;

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

    [JsonPropertyName("trackingLogEntryIdResult")]
    public string? TrackingLogEntryIdResult { get; set; }
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

    [JsonPropertyName("possibleValues")]
    public List<string>? PossibleValues { get; set; }

    [JsonPropertyName("dataType")]
    public string? DataType { get; set; }

    [JsonPropertyName("dataTypeName")]
    public string? DataTypeName { get; set; }
}

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

public class AssemblyDto
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = "";

    [JsonPropertyName("cadId")]
    public string? CadId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("currentTrackingStatusId")]
    public string? CurrentTrackingStatusId { get; set; }

    [JsonPropertyName("currentDivisionId")]
    public string? CurrentDivisionId { get; set; }

    [JsonPropertyName("fieldIdToValueMap")]
    public Dictionary<string, string?>? FieldIdToValueMap { get; set; }

    [JsonPropertyName("fieldNameToValueMap")]
    public Dictionary<string, string?>? FieldNameToValueMap { get; set; }
}

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

public class FieldValuePair
{
    [JsonPropertyName("key")]
    public string Key { get; set; } = "";

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

public class StratusApiConfig
{
    public string BaseUrl { get; set; } = "https://api.gtpstratus.com";
    public string ApiKey { get; set; } = "";
    public int TimeoutSeconds { get; set; } = 30;
    public int MaxRetries { get; set; } = 3;
}
