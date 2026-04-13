using Microsoft.EntityFrameworkCore;

namespace DUAStreamliner.Infrastructure.Persistence;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // TODO: add DbSet<> members when the persistence model is defined.
}
