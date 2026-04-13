using DUAStreamliner.Application.Results;
using DUAStreamliner.Domain.Results;

namespace DUAStreamliner.Infrastructure.Persistence.Repositories;

public sealed class ResultRepository : IResultRepository
{
    public Task<ExecutionResult?> GetByExecutionIdAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
