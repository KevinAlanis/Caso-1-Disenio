namespace DUAStreamliner.Domain.Executions;

public sealed class Execution
{
    public Guid Id { get; set; }

    public ExecutionStatus Status { get; set; }
}
