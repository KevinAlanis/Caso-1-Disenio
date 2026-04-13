using DUAStreamliner.Domain.Executions;
using DUAStreamliner.Shared.DTOs;

namespace DUAStreamliner.Application.Executions;

public sealed class ExecutionAppService
{
    public Task<Guid> CreateExecutionAsync(CreateExecutionRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task StartProcessingAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Execution?> GetExecutionAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
