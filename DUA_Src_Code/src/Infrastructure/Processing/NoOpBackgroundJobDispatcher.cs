using DUAStreamliner.Application.Processing;

namespace DUAStreamliner.Infrastructure.Processing;

public sealed class NoOpBackgroundJobDispatcher : IBackgroundJobDispatcher
{
    public Task EnqueueAsync(ProcessingJob job, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
