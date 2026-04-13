# DUA Streamliner — Backend Skeleton

This folder hosts the **DUA Streamliner** modular monolith backend (ASP.NET Core 8). The tree is intentionally limited to **contracts, placeholders, and composition**—there is no business logic, persistence, or Azure integration implemented yet.

## Quick links (relative to this `README.md`)

- [Backend root](.)
- [Solution file](./DUAStreamliner.sln)
- [API layer](./src/Api/)
- [Application layer](./src/Application/)
- [Domain layer](./src/Domain/)
- [Infrastructure layer](./src/Infrastructure/)
- [Shared contracts](./src/Shared/)
- [Unit tests](./tests/UnitTests/)
- [Integration tests](./tests/IntegrationTests/)

## Key files

- [ExecutionsController](./src/Api/Controllers/ExecutionsController.cs)
- [DocumentsController](./src/Api/Controllers/DocumentsController.cs)
- [TemplatesController](./src/Api/Controllers/TemplatesController.cs)
- [ResultsController](./src/Api/Controllers/ResultsController.cs)
- [MonitoringController](./src/Api/Controllers/MonitoringController.cs)
- [Program (DI + OpenAPI placeholder)](./src/Api/Program.cs)
- [OpenAPI registration](./src/Api/OpenApi/OpenApiConfiguration.cs)
- [ExecutionAppService](./src/Application/Executions/ExecutionAppService.cs)
- [Execution entity](./src/Domain/Executions/Execution.cs)
- [IExecutionRepository](./src/Application/Executions/IExecutionRepository.cs)
- [ExecutionRepository (stub)](./src/Infrastructure/Persistence/Repositories/ExecutionRepository.cs)
- [AppDbContext (placeholder)](./src/Infrastructure/Persistence/AppDbContext.cs)
- [BlobStorageService (placeholder)](./src/Infrastructure/Blobs/BlobStorageService.cs)
- [NotificationHubService (placeholder)](./src/Infrastructure/Notifications/NotificationHubService.cs)
- [TelemetryService (placeholder)](./src/Infrastructure/Telemetry/TelemetryService.cs)
- [PolicyRegistry](./src/Infrastructure/Security/PolicyRegistry.cs)
