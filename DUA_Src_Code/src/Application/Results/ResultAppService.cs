using DUAStreamliner.Domain.Results;

namespace DUAStreamliner.Application.Results;

public sealed class ResultAppService
{
    public Task<ExecutionResult?> GetResultAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Stream> OpenResultArtifactStreamAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
