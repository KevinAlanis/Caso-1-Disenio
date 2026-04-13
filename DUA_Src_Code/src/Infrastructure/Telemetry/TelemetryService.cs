namespace DUAStreamliner.Infrastructure.Telemetry;

public sealed class TelemetryService
{
    public Task TrackEventAsync(string name, IReadOnlyDictionary<string, string>? properties = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
