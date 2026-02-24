using System;
using System.IO;
using System.Reflection;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;
using Microsoft.Extensions.DependencyInjection;
using StratusRevit.RevitAdapter.Revit2023;
using StratusRevit.SyncEngine;

namespace StratusRevit.Addin.Revit2023;

[Transaction(TransactionMode.Manual)]
public class DryRunCommand : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        try
        {
            var addinDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "";
            var configPath = Path.Combine(addinDir, "stratus-addin.json");
            var config = StratusAddinConfig.LoadFromFile(configPath);

            var mappingPath = Path.Combine(addinDir, config.MappingConfigPath);
            var mappingConfig = File.Exists(mappingPath)
                ? System.Text.Json.JsonSerializer.Deserialize<Domain.MappingConfig>(File.ReadAllText(mappingPath))
                  ?? new Domain.MappingConfig()
                : new Domain.MappingConfig();

            // Create and initialise the Revit 2023 context with the live UIApplication
            var revitContext = new Revit2023Context();
            revitContext.Initialise(commandData.Application);

            var services = DependencyContainer.Build(config, mappingConfig, revitContext);
            var engine = services.GetRequiredService<ISyncEngine>();

            var selected = revitContext.GetSelectedElements();
            var report = engine.DryRunAsync(selected).GetAwaiter().GetResult();

            TaskDialog.Show("Stratus – Dry Run",
                $"Elements: {report.TotalElements}\n" +
                $"Changes planned: {report.ChangesPlanned}\n\n" +
                "No data was sent to Stratus.");

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
