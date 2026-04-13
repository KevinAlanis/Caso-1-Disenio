using DUAStreamliner.Domain.Templates;

namespace DUAStreamliner.Application.Templates;

public interface ITemplateRepository
{
    Task<DuaTemplate?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    Task<IReadOnlyList<DuaTemplate>> ListAsync(CancellationToken cancellationToken = default);
}
