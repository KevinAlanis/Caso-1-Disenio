namespace DUAStreamliner.Application.Processing;

public sealed class ProcessingProgressSnapshot
{
    public Guid ExecutionId { get; set; }

    public int? PercentComplete { get; set; }
}
