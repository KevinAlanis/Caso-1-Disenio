using DUAStreamliner.Api.OpenApi;
using DUAStreamliner.Application;
using DUAStreamliner.Infrastructure;
using DUAStreamliner.Infrastructure.Security;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(OpenApiConfiguration.ConfigureSwaggerGen);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(
        PolicyRegistry.ExecutionOwnership,
        policy => policy.Requirements.Add(new ExecutionOwnershipRequirement()));

    options.AddPolicy(
        PolicyRegistry.ResultDownload,
        policy => policy.Requirements.Add(new ResultDownloadRequirement()));
});

// TODO: configure authentication (Microsoft Entra ID / App Service Easy Auth) when required.

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public partial class Program
{
}
