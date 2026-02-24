using System;
using StratusRevit.RevitAdapter.Abstractions;

namespace StratusRevit.RevitAdapter.Revit2023;

public class Revit2023HostInfo : IRevitHostInfo
{
    public string VersionMajor => "2023";
    public string AdapterId => "Revit2023";
}
