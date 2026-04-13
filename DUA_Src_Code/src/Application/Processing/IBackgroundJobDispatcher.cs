namespace DUAStreamliner.Application.Processing;

public interface IBackgroundJobDispatcher
{
    Task EnqueueAsync(ProcessingJob job, CancellationToken cancellationToken = default);
}
