namespace DUAStreamliner.Domain.Results;

public sealed class ExecutionResult
{
    public Guid Id { get; set; }

    public Guid ExecutionId { get; set; }

    public ResultConfidenceLevel Confidence { get; set; }
}
