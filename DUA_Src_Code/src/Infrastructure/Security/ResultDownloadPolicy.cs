using Microsoft.AspNetCore.Authorization;

namespace DUAStreamliner.Infrastructure.Security;

public sealed class ResultDownloadPolicy : AuthorizationHandler<ResultDownloadRequirement>
{
    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        ResultDownloadRequirement requirement)
    {
        throw new NotImplementedException();
    }
}
