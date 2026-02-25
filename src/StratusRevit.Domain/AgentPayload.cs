using System.Text.Json.Serialization;
using StratusRevit.RevitAdapter.Abstractions;

namespace StratusRevit.Domain;

/// <summary>
/// JSON payload written by the Revit addin and consumed by the out-of-process PushAgent.
/// Contains everything the agent needs to run without touching Revit.
/// </summary>
public class AgentPayload
{
    [JsonPropertyName("mode")]
    public AgentMode Mode { get; set; } = AgentMode.DryRun;

    [JsonPropertyName("apiConfig")]
    public AgentApiConfig ApiConfig { get; set; } = new();

    [JsonPropertyName("mappingConfig")]
    public MappingConfig MappingConfig { get; set; } = new();

    [JsonPropertyName("elements")]
    public List<AgentElement> Elements { get; set; } = new();
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AgentMode
{
    DryRun,
    Push
}

/// <summary>Flat API connection settings (no Revit dependencies).</summary>
public class AgentApiConfig
{
    [JsonPropertyName("baseUrl")]
    public string BaseUrl { get; set; } = "https://api.gtpstratus.com";

    [JsonPropertyName("apiKey")]
    public string ApiKey { get; set; } = "";

    [JsonPropertyName("timeoutSeconds")]
    public int TimeoutSeconds { get; set; } = 30;

    [JsonPropertyName("maxRetries")]
    public int MaxRetries { get; set; } = 3;
}

/// <summary>
/// Serialisable element snapshot. Mirrors <see cref="RevitElementData"/> but uses
/// concrete collections for JSON round-tripping.
/// </summary>
public class AgentElement
{
    [JsonPropertyName("elementId")]
    public string ElementId { get; set; } = "";

    [JsonPropertyName("uniqueId")]
    public string UniqueId { get; set; } = "";

    [JsonPropertyName("elementType")]
    public string ElementType { get; set; } = "";

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("parameters")]
    public Dictionary<string, string?> Parameters { get; set; } = new();

    /// <summary>Convert to the domain record consumed by ChangeMapper / SyncEngine.</summary>
    public RevitElementData ToRevitElementData()
        => new(ElementId, UniqueId, ElementType, Name, Parameters);
}

/// <summary>
/// JSON result written by the PushAgent, read by the Revit addin for display.
/// </summary>
public class AgentResult
{
    [JsonPropertyName("success")]
    public bool Success { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("isDryRun")]
    public bool IsDryRun { get; set; }

    [JsonPropertyName("totalElements")]
    public int TotalElements { get; set; }

    [JsonPropertyName("changesPlanned")]
    public int ChangesPlanned { get; set; }

    [JsonPropertyName("changesSucceeded")]
    public int ChangesSucceeded { get; set; }

    [JsonPropertyName("changesFailed")]
    public int ChangesFailed { get; set; }

    [JsonPropertyName("results")]
    public List<AgentChangeResult> Results { get; set; } = new();
}

public class AgentChangeResult
{
    [JsonPropertyName("stratusObjectId")]
    public string StratusObjectId { get; set; } = "";

    [JsonPropertyName("revitElementId")]
    public string RevitElementId { get; set; } = "";

    [JsonPropertyName("fieldName")]
    public string FieldName { get; set; } = "";

    [JsonPropertyName("oldValue")]
    public string? OldValue { get; set; }

    [JsonPropertyName("newValue")]
    public string? NewValue { get; set; }

    [JsonPropertyName("isSuccess")]
    public bool IsSuccess { get; set; }

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }
}
