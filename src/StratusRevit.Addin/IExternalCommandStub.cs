namespace StratusRevit.Addin;

/// <summary>
/// Stub for Autodesk.Revit.UI.IExternalCommand.
/// In production, reference RevitAPIUI.dll from the Revit installation.
/// </summary>
public interface IExternalCommand
{
    Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements);
}

/// <summary>Stub for Autodesk.Revit.UI.IExternalApplication.</summary>
public interface IExternalApplication
{
    Result OnStartup(UIControlledApplication application);
    Result OnShutdown(UIControlledApplication application);
}

public enum Result { Succeeded, Failed, Cancelled }
public class ExternalCommandData { }
public class ElementSet { }
public class UIControlledApplication { }
