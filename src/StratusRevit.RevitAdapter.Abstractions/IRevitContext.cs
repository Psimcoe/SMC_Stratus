namespace StratusRevit.RevitAdapter.Abstractions;

/// <summary>Element data extracted from a Revit document.</summary>
public record RevitElementData(
    string ElementId,
    string UniqueId,
    string ElementType,
    string? Name,
    IReadOnlyDictionary<string, string?> Parameters
);

/// <summary>Reads element data from the current Revit context.</summary>
public interface IRevitContext
{
    string HostVersionMajor { get; }
    IReadOnlyList<RevitElementData> GetSelectedElements();
    IReadOnlyList<RevitElementData> GetAllElements();
    string? GetDocumentTitle();
    string? GetProjectNumber();
}
