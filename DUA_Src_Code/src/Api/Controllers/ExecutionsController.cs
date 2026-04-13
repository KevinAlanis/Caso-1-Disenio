using DUAStreamliner.Application.Executions;
using DUAStreamliner.Domain.Executions;
using DUAStreamliner.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DUAStreamliner.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class ExecutionsController : ControllerBase
{
    private readonly ExecutionAppService _executions;

    public ExecutionsController(ExecutionAppService executions)
    {
        _executions = executions;
    }

    [HttpPost]
    public async Task<ActionResult<Guid>> CreateAsync([FromBody] CreateExecutionRequest request, CancellationToken cancellationToken)
    {
        var id = await _executions.CreateExecutionAsync(request, cancellationToken).ConfigureAwait(false);
        return Ok(id);
    }

    [HttpGet("{executionId:guid}")]
    public async Task<ActionResult<Execution>> GetAsync(Guid executionId, CancellationToken cancellationToken)
    {
        var execution = await _executions.GetExecutionAsync(executionId, cancellationToken).ConfigureAwait(false);
        return Ok(execution);
    }

    [HttpPost("{executionId:guid}/processing/start")]
    public async Task<ActionResult> StartProcessingAsync(Guid executionId, CancellationToken cancellationToken)
    {
        await _executions.StartProcessingAsync(executionId, cancellationToken).ConfigureAwait(false);
        return Accepted();
    }
}
