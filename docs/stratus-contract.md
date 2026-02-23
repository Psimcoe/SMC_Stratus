# Stratus API Contract

Base URL: `https://api.gtpstratus.com`
Auth: `x-api-key` header (from Admin > Company > App Keys)

## Implemented Endpoints

| Method | Path | Notes |
|--------|------|-------|
| GET | `/company/trackingstatuses` | Returns `[{ id, name, trackingStatusGroupId, trackingStatusGroupName }]` |
| GET | `/company/fields` | Returns fields with `isEditable` flag |
| POST | `/v1/assembly/{id}/trackingstatus` | Body: `TrackingStatusUpdateRequest` |
| POST | `/v1/assembly/{id}/field` | Body: `{ key, value }` |
| POST | `/v1/assembly/{id}/fields` | Body: `[{ key, value }]` |
| GET | `/v1/assembly/{id}` | Returns `AssemblyDto` |

## DTOs

See `src/StratusRevit.StratusApi/Dtos.cs` for full DTO definitions.
