# Plan

## Endpoint Inventory
- GET /company/trackingstatuses
- GET /company/fields
- POST /v1/assembly/{id}/trackingstatus
- POST /v1/assembly/{id}/field
- POST /v1/assembly/{id}/fields
- GET /v1/assembly/{id}

## DTO Inventory
- TrackingStatusUpdateRequest / Response
- FieldDto
- TrackingStatusDto
- AssemblyDto
- PagedResponse<T>
- FieldValuePair
- StratusApiConfig

## Mapping Config Schema
See MappingConfig.cs — version, conflictPolicy, fieldMappings[]

## Open Questions
See open-questions.md
