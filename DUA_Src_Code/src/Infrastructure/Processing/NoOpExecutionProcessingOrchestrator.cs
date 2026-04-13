using DUAStreamliner.Application.Processing;

namespace DUAStreamliner.Infrastructure.Processing;

public sealed class NoOpExecutionProcessingOrchestrator : IExecutionProcessingOrchestrator
{
    public Task ScheduleExecutionRunAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
