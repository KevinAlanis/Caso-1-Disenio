using DUAStreamliner.Application.Documents;
using DUAStreamliner.Domain.Documents;

namespace DUAStreamliner.Infrastructure.Persistence.Repositories;

public sealed class DocumentRepository : IDocumentRepository
{
    public Task AddAsync(Document document, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Document>> ListByExecutionAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
