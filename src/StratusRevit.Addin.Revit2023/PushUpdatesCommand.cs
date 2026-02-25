using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
using StratusRevit.Domain;
using StratusRevit.RevitAdapter.Revit2023;

namespace StratusRevit.Addin.Revit2023;

[Transaction(TransactionMode.Manual)]
public class PushUpdatesCommand : IExternalCommand
{
    private static readonly JsonSerializerOptions JsonOpts = new()
    {
        PropertyNameCaseInsensitive = true,
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        try
        {
            var addinDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "";
            var config = StratusAddinConfig.LoadFromFile(Path.Combine(addinDir, "stratus-addin.json"));

            var mappingPath = Path.Combine(addinDir, config.MappingConfigPath);
            var mappingConfig = File.Exists(mappingPath)
                ? JsonSerializer.Deserialize<MappingConfig>(File.ReadAllText(mappingPath), JsonOpts)
                  ?? new MappingConfig()
                : new MappingConfig();

            // ── Extract element data from Revit (pure Revit API, no HTTP) ──
            var revitContext = new Revit2023Context();
            revitContext.Initialise(commandData.Application);
            var selected = revitContext.GetSelectedElements();

            // ── Build payload for the out-of-process agent ──
            var payload = new AgentPayload
            {
                Mode = AgentMode.Push,
                ApiConfig = new AgentApiConfig
                {
                    BaseUrl = config.BaseUrl,
                    ApiKey = config.ApiKey,
                    TimeoutSeconds = config.TimeoutSeconds,
                    MaxRetries = config.MaxRetries
                },
                MappingConfig = mappingConfig,
                Elements = selected.Select(e => new AgentElement
                {
                    ElementId = e.ElementId,
                    UniqueId = e.UniqueId,
                    ElementType = e.ElementType,
                    Name = e.Name,
                    Parameters = e.Parameters.ToDictionary(kvp => kvp.Key, kvp => kvp.Value)
                }).ToList()
            };

            // ── Launch PushAgent.exe (net8.0) in its own process ──
            var agentResult = AgentLauncher.Run(addinDir, payload, JsonOpts);

            // ── Display results ──
            var details = "";
            if (agentResult.ChangesFailed > 0)
            {
                details = "\n\nFailed changes:\n";
                foreach (var r in agentResult.Results.Where(r => !r.IsSuccess))
                    details += $"  [{r.FieldName}] {r.OldValue} -> {r.NewValue}: {r.ErrorMessage}\n";
            }
            if (agentResult.ChangesSucceeded > 0)
            {
                details += "\n\nSucceeded:\n";
                foreach (var r in agentResult.Results.Where(r => r.IsSuccess))
                    details += $"  [{r.FieldName}] -> {r.NewValue}\n";
            }
            if (!string.IsNullOrEmpty(agentResult.Error))
            {
                details += $"\n\nAgent error: {agentResult.Error}";
            }

            TaskDialog.Show("Stratus – Push Results",
                $"Elements: {agentResult.TotalElements}\n" +
                $"Succeeded: {agentResult.ChangesSucceeded}\n" +
                $"Failed: {agentResult.ChangesFailed}" + details);

            return Result.Succeeded;
        }
        catch (Exception ex)
        {
            message = $"PushUpdates failed: {ex.Message}";
            TaskDialog.Show("Stratus – Error", message);
            return Result.Failed;
        }
    }
}
