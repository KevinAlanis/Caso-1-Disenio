using DUAStreamliner.Application.Templates;
using DUAStreamliner.Domain.Templates;

namespace DUAStreamliner.Infrastructure.Persistence.Repositories;

public sealed class TemplateRepository : ITemplateRepository
{
    public Task<DuaTemplate?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<DuaTemplate>> ListAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
