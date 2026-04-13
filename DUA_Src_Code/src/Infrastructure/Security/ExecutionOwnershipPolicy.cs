using Microsoft.AspNetCore.Authorization;

namespace DUAStreamliner.Infrastructure.Security;

public sealed class ExecutionOwnershipPolicy : AuthorizationHandler<ExecutionOwnershipRequirement>
{
    protected override Task HandleRequirementAsync(
        AuthorizationHandlerContext context,
        ExecutionOwnershipRequirement requirement)
    {
        throw new NotImplementedException();
    }
}
