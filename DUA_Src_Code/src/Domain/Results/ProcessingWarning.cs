namespace DUAStreamliner.Domain.Results;

public sealed class ProcessingWarning
{
    public Guid Id { get; set; }

    public Guid ExecutionId { get; set; }
}
