using DUAStreamliner.Domain.Documents;
using DUAStreamliner.Shared.DTOs;

namespace DUAStreamliner.Application.Documents;

public sealed class DocumentAppService
{
    public Task<Guid> RegisterDocumentUploadAsync(Guid executionId, RegisterDocumentUploadRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<Document>> ListDocumentsForExecutionAsync(Guid executionId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
