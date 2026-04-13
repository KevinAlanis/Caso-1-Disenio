using DUAStreamliner.Application.Security;
using Microsoft.AspNetCore.Http;

namespace DUAStreamliner.Infrastructure.Security;

public sealed class CurrentUserAccessor : ICurrentUserAccessor
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CurrentUserAccessor(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? GetObjectId()
    {
        _ = _httpContextAccessor.HttpContext;
        throw new NotImplementedException();
    }

    public IReadOnlyList<string> GetRoleClaims()
    {
        _ = _httpContextAccessor.HttpContext;
        throw new NotImplementedException();
    }
}
