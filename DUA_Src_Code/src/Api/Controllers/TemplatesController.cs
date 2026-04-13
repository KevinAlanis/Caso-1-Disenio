using DUAStreamliner.Application.Templates;
using DUAStreamliner.Domain.Templates;
using DUAStreamliner.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace DUAStreamliner.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class TemplatesController : ControllerBase
{
    private readonly TemplateAppService _templates;

    public TemplatesController(TemplateAppService templates)
    {
        _templates = templates;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<DuaTemplate>>> ListAsync(CancellationToken cancellationToken)
    {
        var items = await _templates.ListTemplatesAsync(cancellationToken).ConfigureAwait(false);
        return Ok(items);
    }

    [HttpPost("executions/{executionId:guid}/selection")]
    public async Task<ActionResult> SelectForExecutionAsync(
        Guid executionId,
        [FromBody] SelectTemplateRequest request,
        CancellationToken cancellationToken)
    {
        await _templates.SelectTemplateForExecutionAsync(executionId, request, cancellationToken).ConfigureAwait(false);
        return Accepted();
    }

    [HttpPost("{templateId:guid}/configuration")]
    public async Task<ActionResult> ConfigureAsync(Guid templateId, CancellationToken cancellationToken)
    {
        await _templates.ConfigureTemplateAsync(templateId, cancellationToken).ConfigureAwait(false);
        return Accepted();
    }
}
