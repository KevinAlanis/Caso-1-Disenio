using DUAStreamliner.Application.Monitoring;
using DUAStreamliner.Application.Processing;
using Microsoft.AspNetCore.Mvc;

namespace DUAStreamliner.Api.Controllers;

[ApiController]
[Route("api/executions/{executionId:guid}/[controller]")]
public sealed class MonitoringController : ControllerBase
{
    private readonly MonitoringAppService _monitoring;

    public MonitoringController(MonitoringAppService monitoring)
    {
        _monitoring = monitoring;
    }

    [HttpGet("progress")]
    public async Task<ActionResult<ProcessingProgressSnapshot>> GetProgressAsync(Guid executionId, CancellationToken cancellationToken)
    {
        var snapshot = await _monitoring.GetProgressAsync(executionId, cancellationToken).ConfigureAwait(false);
        return Ok(snapshot);
    }

    [HttpGet("status-label")]
    public async Task<ActionResult<string>> GetStatusLabelAsync(Guid executionId, CancellationToken cancellationToken)
    {
        var label = await _monitoring.GetExecutionStatusLabelAsync(executionId, cancellationToken).ConfigureAwait(false);
        return Ok(label);
    }
}
