namespace StratusRevit.RevitAdapter.Abstractions;

public interface IRevitHostInfo
{
    string VersionMajor { get; }
    string AdapterId { get; }
}
