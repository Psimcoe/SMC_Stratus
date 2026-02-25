using System;
using System.Collections.Generic;
using System.Diagnostics;
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
public class DryRunCommand : IExternalCommand
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
                Mode = AgentMode.DryRun,
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

            // ── Diagnostic info for the first selected element ──
            var diagMsg = "";
            if (selected.Count > 0)
            {
                var elem = selected[0];
                diagMsg = $"\n\n--- DEBUG: Element '{elem.Name}' ---\n";
                foreach (var kvp in elem.Parameters)
                {
                    if (kvp.Key.IndexOf("STRATUS", StringComparison.OrdinalIgnoreCase) >= 0
                        || kvp.Key.IndexOf("Comment", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        diagMsg += $"  [{kvp.Key}] = [{kvp.Value}]\n";
                    }
                }
                diagMsg += $"\nMapping rules loaded: {mappingConfig.FieldMappings.Count}\n";
                diagMsg += $"Stratus ID param: {mappingConfig.StratusIdParameter ?? "(none, using UniqueId)"}\n";
                diagMsg += $"QR code param: {mappingConfig.StratusQrCodeParameter ?? "(none)"}\n\n";
                foreach (var rule in mappingConfig.FieldMappings)
                {
                    var found = elem.Parameters.TryGetValue(rule.RevitParameter, out var val);
                    diagMsg += $"  '{rule.RevitParameter}' -> {(found ? $"FOUND = [{val}]" : "NOT FOUND")}";
                    if (rule.IsTrackingStatus) diagMsg += " [tracking-status]";
                    diagMsg += "\n";
                }
            }

            TaskDialog.Show("Stratus – Dry Run",
                $"Elements: {agentResult.TotalElements}\n" +
                $"Changes planned: {agentResult.ChangesPlanned}\n\n" +
                "No data was sent to Stratus." + diagMsg);

            return Result.Succeeded;
        }
        catch (Exception ex)
        {
            message = $"DryRun failed: {ex.Message}";
            TaskDialog.Show("Stratus – Error", message);
            return Result.Failed;
        }
    }
}
