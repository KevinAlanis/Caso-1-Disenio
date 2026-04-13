using DUAStreamliner.Application.Audit;
using DUAStreamliner.Application.Documents;
using DUAStreamliner.Application.Executions;
using DUAStreamliner.Application.Monitoring;
using DUAStreamliner.Application.Results;
using DUAStreamliner.Application.Templates;
using Microsoft.Extensions.DependencyInjection;

namespace DUAStreamliner.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<ExecutionAppService>();
        services.AddScoped<DocumentAppService>();
        services.AddScoped<TemplateAppService>();
        services.AddScoped<ResultAppService>();
        services.AddScoped<MonitoringAppService>();
        services.AddScoped<AuditAppService>();

        return services;
    }
}
