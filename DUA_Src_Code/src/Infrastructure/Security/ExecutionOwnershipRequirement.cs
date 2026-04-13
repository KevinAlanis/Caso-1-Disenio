using Microsoft.AspNetCore.Authorization;

namespace DUAStreamliner.Infrastructure.Security;

public sealed class ExecutionOwnershipRequirement : IAuthorizationRequirement
{
}
