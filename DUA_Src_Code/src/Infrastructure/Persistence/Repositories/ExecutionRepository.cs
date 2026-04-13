using DUAStreamliner.Application.Executions;
using DUAStreamliner.Domain.Executions;

namespace DUAStreamliner.Infrastructure.Persistence.Repositories;

public sealed class ExecutionRepository : IExecutionRepository
{
    public Task AddAsync(Execution execution, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Execution?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Execution execution, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
