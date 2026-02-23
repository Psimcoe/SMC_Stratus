# StratusRevit - Revit-Stratus Integration Solution

A complete, buildable .NET 8.0 solution that synchronizes data between Autodesk Revit and GTP Stratus project management platform.

## Quick Start

```bash
cd /home/runner/work/SMC_Stratus/SMC_Stratus
dotnet build StratusRevit.slnx --configuration Release
dotnet test tests/StratusRevit.Tests/StratusRevit.Tests.csproj --configuration Release
```

## Solution Status

✅ **Complete & Buildable**
- 7 projects (4 core libs + 2 adapter/addin + 1 test)
- 16/16 unit tests passing
- 0 compilation errors, 0 warnings
- GitHub Actions CI configured (.github/workflows/build.yml)

## Architecture Overview

```
Revit Addin
    ↓
SyncEngine (orchestration)
    ├── Domain (mapping, validation)
    ├── StratusApi (HTTP client)
    └── Abstractions (interfaces)
         ↓
RevitAdapter.Revit2025 (version-specific)
```

## Key Features

- **Field Mapping**: JSON-based configuration maps Revit parameters to Stratus fields
- **Conflict Resolution**: RevitWins, StratusWins, or DoNotChange policies
- **Normalization**: Trim, lowercase, uppercase rules
- **Dry Run**: Preview changes without API calls
- **Audit Logging**: Records all sync attempts
- **Retry Logic**: Exponential backoff on API failures
- **Extensible**: Adapter pattern for future Revit versions
