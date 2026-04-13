namespace DUAStreamliner.Infrastructure.Security;

public sealed class AuthorizationService
{
    public Task<bool> CanAccessExecutionAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CanDownloadResultAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
