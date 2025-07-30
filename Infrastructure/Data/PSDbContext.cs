namespace Infrastructure.Data;

using Microsoft.EntityFrameworkCore;

public sealed class PSDbContext(DbContextOptions<PSDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PSDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}