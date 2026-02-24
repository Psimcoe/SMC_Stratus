using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace StratusRevit.Addin.Revit2023;

[Transaction(TransactionMode.Manual)]
public class StratusRevitApp : IExternalApplication
{
    public Result OnStartup(UIControlledApplication application)
    {
        // TODO: Add ribbon panel / buttons if desired
        return Result.Succeeded;
    }

    public Result OnShutdown(UIControlledApplication application)
    {
        return Result.Succeeded;
    }
}
