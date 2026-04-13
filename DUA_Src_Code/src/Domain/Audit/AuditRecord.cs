namespace DUAStreamliner.Domain.Audit;

public sealed class AuditRecord
{
    public Guid Id { get; set; }

    public Guid? ExecutionId { get; set; }

    public AuditEventType EventType { get; set; }
}
