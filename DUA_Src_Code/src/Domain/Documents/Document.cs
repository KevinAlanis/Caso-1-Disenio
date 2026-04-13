namespace DUAStreamliner.Domain.Documents;

public sealed class Document
{
    public Guid Id { get; set; }

    public Guid ExecutionId { get; set; }

    public DocumentStatus Status { get; set; }
}
