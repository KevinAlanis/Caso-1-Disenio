using DUAStreamliner.Domain.Results;

namespace DUAStreamliner.Application.Results;

public interface IResultRepository
{
    Task<ExecutionResult?> GetByExecutionIdAsync(Guid executionId, CancellationToken cancellationToken = default);
}
