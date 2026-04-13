using DUAStreamliner.Domain.Templates;
using DUAStreamliner.Shared.DTOs;

namespace DUAStreamliner.Application.Templates;

public sealed class TemplateAppService
{
    public Task<IReadOnlyList<DuaTemplate>> ListTemplatesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task SelectTemplateForExecutionAsync(Guid executionId, SelectTemplateRequest request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task ConfigureTemplateAsync(Guid templateId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
