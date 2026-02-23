# Architecture

## Layers

Revit Addin (StratusRevit.Addin)
         |
         v
  SyncEngine (orchestration)
    |-- Domain (mapping, validation, change planning)
    |-- StratusApi (HTTP client -> Stratus REST API)
    |-- RevitAdapter.Abstractions (IRevitContext, DTOs)
         |
         v
  RevitAdapter.Revit2025 (reads Revit model)

## Data Flow

1. **Read** – `IRevitContext.GetSelectedElements()` returns `RevitElementData[]`
2. **Map** – `ChangeMapper` applies `MappingConfig` field rules → `ChangeIntent[]`
3. **Validate** – `ChangeValidator` checks tracking status IDs and `isEditable` flags
4. **Dry Run / Push** – `SyncEngine.DryRunAsync` returns report without calling API; `PushUpdatesAsync` calls API
5. **Audit** – Every attempted change is logged via `AuditLogger`

## Version Strategy

Each Revit version gets its own adapter project (e.g. `RevitAdapter.Revit2025`, `RevitAdapter.Revit2026`).
The adapter implements `IRevitContext` and `IRevitHostInfo` from Abstractions.
The rest of the stack is version-agnostic.
