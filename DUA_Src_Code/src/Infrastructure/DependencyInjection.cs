using DUAStreamliner.Application.Documents;
using DUAStreamliner.Application.Executions;
using DUAStreamliner.Application.Processing;
using DUAStreamliner.Application.Results;
using DUAStreamliner.Application.Security;
using DUAStreamliner.Application.Templates;
using DUAStreamliner.Infrastructure.Blobs;
using DUAStreamliner.Infrastructure.Notifications;
using DUAStreamliner.Infrastructure.Persistence.Repositories;
using DUAStreamliner.Infrastructure.Processing;
using DUAStreamliner.Infrastructure.Security;
using DUAStreamliner.Infrastructure.Telemetry;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DUAStreamliner.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        _ = configuration;
        services.AddHttpContextAccessor();

        // TODO: services.AddDbContext<AppDbContext>(...) when an EF Core provider and migrations exist.

        services.AddScoped<IExecutionRepository, ExecutionRepository>();
        services.AddScoped<IDocumentRepository, DocumentRepository>();
        services.AddScoped<ITemplateRepository, TemplateRepository>();
        services.AddScoped<IResultRepository, ResultRepository>();

        services.AddScoped<BlobStorageService>();
        services.AddScoped<NotificationHubService>();
        services.AddScoped<TelemetryService>();

        services.AddScoped<ICurrentUserAccessor, CurrentUserAccessor>();
        services.AddScoped<AuthorizationService>();

        services.AddSingleton<IBackgroundJobDispatcher, NoOpBackgroundJobDispatcher>();
        services.AddSingleton<IExecutionProcessingOrchestrator, NoOpExecutionProcessingOrchestrator>();

        services.AddSingleton<IAuthorizationHandler, ExecutionOwnershipPolicy>();
        services.AddSingleton<IAuthorizationHandler, ResultDownloadPolicy>();

        return services;
    }
}
