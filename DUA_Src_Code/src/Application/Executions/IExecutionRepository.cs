using DUAStreamliner.Domain.Executions;

namespace DUAStreamliner.Application.Executions;

public interface IExecutionRepository
{
    Task<Execution?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task AddAsync(Execution execution, CancellationToken cancellationToken = default);

    Task UpdateAsync(Execution execution, CancellationToken cancellationToken = default);
}
