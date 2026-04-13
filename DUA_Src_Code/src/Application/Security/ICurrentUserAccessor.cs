namespace DUAStreamliner.Application.Security;

public interface ICurrentUserAccessor
{
    string? GetObjectId();

    IReadOnlyList<string> GetRoleClaims();
}
