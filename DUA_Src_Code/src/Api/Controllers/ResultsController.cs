using DUAStreamliner.Application.Results;
using DUAStreamliner.Domain.Results;
using Microsoft.AspNetCore.Mvc;

namespace DUAStreamliner.Api.Controllers;

[ApiController]
[Route("api/executions/{executionId:guid}/[controller]")]
public sealed class ResultsController : ControllerBase
{
    private readonly ResultAppService _results;

    public ResultsController(ResultAppService results)
    {
        _results = results;
    }

    [HttpGet]
    public async Task<ActionResult<ExecutionResult>> GetAsync(Guid executionId, CancellationToken cancellationToken)
    {
        var result = await _results.GetResultAsync(executionId, cancellationToken).ConfigureAwait(false);
        return Ok(result);
    }

    [HttpGet("artifact")]
    public async Task<ActionResult> DownloadArtifactAsync(Guid executionId, CancellationToken cancellationToken)
    {
        await using var stream = await _results.OpenResultArtifactStreamAsync(executionId, cancellationToken)
            .ConfigureAwait(false);
        return File(stream, contentType: "application/octet-stream", fileDownloadName: "artifact.bin");
    }
}
