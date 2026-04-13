namespace DUAStreamliner.Application.Processing;

public interface IExecutionProcessingOrchestrator
{
    Task ScheduleExecutionRunAsync(Guid executionId, CancellationToken cancellationToken = default);
}
