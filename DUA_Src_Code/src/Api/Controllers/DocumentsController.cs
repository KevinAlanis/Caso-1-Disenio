using DUAStreamliner.Application.Documents;
using DUAStreamliner.Domain.Documents;
using DUAStreamliner.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DUAStreamliner.Api.Controllers;

[ApiController]
[Route("api/executions/{executionId:guid}/[controller]")]
public sealed class DocumentsController : ControllerBase
{
    private readonly DocumentAppService _documents;

    public DocumentsController(DocumentAppService documents)
    {
        _documents = documents;
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> RegisterUploadAsync(
        Guid executionId,
        [FromBody] RegisterDocumentUploadRequest request,
        CancellationToken cancellationToken)
    {
        var id = await _documents.RegisterDocumentUploadAsync(executionId, request, cancellationToken).ConfigureAwait(false);
        return Created(string.Empty, id);
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<Document>>> ListAsync(Guid executionId, CancellationToken cancellationToken)
    {
        var items = await _documents.ListDocumentsForExecutionAsync(executionId, cancellationToken).ConfigureAwait(false);
        return Ok(items);
    }
}
