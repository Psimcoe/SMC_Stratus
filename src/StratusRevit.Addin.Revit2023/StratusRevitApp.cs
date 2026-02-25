using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace StratusRevit.Addin.Revit2023;

[Transaction(TransactionMode.Manual)]
public class StratusRevitApp : IExternalApplication
{
    public Result OnStartup(UIControlledApplication application)
    {
        // No assembly-resolve handler needed: all HTTP work is done out-of-process
        // by StratusRevit.PushAgent.exe (net8.0). The Revit addin only reads
        // element data and serialises JSON.
        return Result.Succeeded;
    }

    public Result OnShutdown(UIControlledApplication application)
    {
        return Result.Succeeded;
    }
}
