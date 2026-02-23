using StratusRevit.RevitAdapter.Abstractions;

namespace StratusRevit.RevitAdapter.Revit2025;

// NOTE: In production, this class uses Autodesk.Revit.DB and Autodesk.Revit.UI
// Those DLLs are not referenced here since they must be provided at runtime
// from the Revit 2025 installation directory.
public class Revit2025Context : IRevitContext
{
    public string HostVersionMajor => "2025";

    public IReadOnlyList<RevitElementData> GetSelectedElements()
        => Array.Empty<RevitElementData>();

    public IReadOnlyList<RevitElementData> GetAllElements()
        => Array.Empty<RevitElementData>();

    public string? GetDocumentTitle() => null;
    public string? GetProjectNumber() => null;
}
