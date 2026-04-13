using DUAStreamliner.Domain.Audit;

namespace DUAStreamliner.Application.Audit;

public sealed class AuditAppService
{
    public Task RecordAuditEventAsync(AuditRecord record, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<AuditRecord>> QueryAuditForExecutionAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
