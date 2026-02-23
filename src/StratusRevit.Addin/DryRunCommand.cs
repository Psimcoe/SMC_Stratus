using Microsoft.Extensions.DependencyInjection;
using StratusRevit.RevitAdapter.Abstractions;
using StratusRevit.SyncEngine;

namespace StratusRevit.Addin;

public class DryRunCommand : IExternalCommand
{
    public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
    {
        try
        {
            var config = StratusAddinConfig.LoadFromFile("stratus-addin.json");
            var mappingConfig = new Domain.MappingConfig();
            var services = DependencyContainer.Build(config, mappingConfig);

            var context = services.GetRequiredService<IRevitContext>();
            var engine = services.GetRequiredService<ISyncEngine>();

            var selected = context.GetSelectedElements();
            var report = engine.DryRunAsync(selected).GetAwaiter().GetResult();

            message = $"DryRun: {report.ChangesPlanned} changes planned across {report.TotalElements} elements.";
            return Result.Succeeded;
        }
        catch (Exception ex)
        {
            message = $"DryRun failed: {ex.Message}";
            return Result.Failed;
        }
    }
}
