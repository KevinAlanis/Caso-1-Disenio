using DUAStreamliner.Application.Processing;

namespace DUAStreamliner.Application.Monitoring;

public sealed class MonitoringAppService
{
    public Task<ProcessingProgressSnapshot?> GetProgressAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<string?> GetExecutionStatusLabelAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
