using DUAStreamliner.Domain.Documents;

namespace DUAStreamliner.Application.Documents;

public interface IDocumentRepository
{
    Task<IReadOnlyList<Document>> ListByExecutionAsync(Guid executionId, CancellationToken cancellationToken = default);

    Task AddAsync(Document document, CancellationToken cancellationToken = default);
}
