using System;
using System.Collections.Generic;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using StratusRevit.RevitAdapter.Abstractions;

namespace StratusRevit.RevitAdapter.Revit2023;

/// <summary>
/// Reads element data from the active Revit 2023 document.
/// Requires a <see cref="UIApplication"/> to be injected after
/// the ExternalCommand hands off <c>commandData.Application</c>.
/// </summary>
public class Revit2023Context : IRevitContext
{
    private UIApplication? _uiApp;

    public string HostVersionMajor => "2023";

    /// <summary>Call this from your ExternalCommand before using the context.</summary>
    public void Initialise(UIApplication uiApp) => _uiApp = uiApp;

    public IReadOnlyList<RevitElementData> GetSelectedElements()
    {
        if (_uiApp is null) return Array.Empty<RevitElementData>();

        var uiDoc = _uiApp.ActiveUIDocument;
        if (uiDoc is null) return Array.Empty<RevitElementData>();

        var doc = uiDoc.Document;
        var selectedIds = uiDoc.Selection.GetElementIds();
        var results = new List<RevitElementData>();

        foreach (var id in selectedIds)
        {
            var elem = doc.GetElement(id);
            if (elem is null) continue;
            results.Add(ToElementData(elem));
        }

        return results.AsReadOnly();
    }

    public IReadOnlyList<RevitElementData> GetAllElements()
    {
        if (_uiApp is null) return Array.Empty<RevitElementData>();

        var doc = _uiApp.ActiveUIDocument?.Document;
        if (doc is null) return Array.Empty<RevitElementData>();

        var collector = new FilteredElementCollector(doc)
            .WhereElementIsNotElementType();

        var results = new List<RevitElementData>();
        foreach (var elem in collector)
        {
            results.Add(ToElementData(elem));
        }

        return results.AsReadOnly();
    }

    public string? GetDocumentTitle()
        => _uiApp?.ActiveUIDocument?.Document?.Title;

    public string? GetProjectNumber()
        => _uiApp?.ActiveUIDocument?.Document?
            .ProjectInformation?.Number;

    // ------------------------------------------------------------------
    // Internal helpers
    // ------------------------------------------------------------------

    private static RevitElementData ToElementData(Element elem)
    {
        var parameters = new Dictionary<string, string?>();
        foreach (Parameter param in elem.Parameters)
        {
            if (param.Definition?.Name is null) continue;
            parameters[param.Definition.Name] = param.AsValueString() ?? param.AsString();
        }

        return new RevitElementData(
            ElementId: elem.Id.IntegerValue.ToString(),
            UniqueId: elem.UniqueId,
            ElementType: elem.Category?.Name ?? elem.GetType().Name,
            Name: elem.Name,
            Parameters: parameters
        );
    }
}
