using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace DUAStreamliner.Api.OpenApi;

public static class OpenApiConfiguration
{
    public static void ConfigureSwaggerGen(SwaggerGenOptions options)
    {
        options.SwaggerDoc(
            "v1",
            new OpenApiInfo
            {
                Title = "DUA Streamliner API",
                Version = "v1",
                Description =
                    "REST surface for DUA Streamliner. OpenAPI document generation is enabled for export to Azure API Management (target OpenAPI 3.1 at the gateway).",
            });

        // TODO: add security schemes (Entra ID / Easy Auth) when auth is wired.
    }
}
