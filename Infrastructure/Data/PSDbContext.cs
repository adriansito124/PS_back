namespace Infrastructure.Data;

using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public sealed class PSDbContext(DbContextOptions<PSDbContext> options) : DbContext(options)
{
    public DbSet<Register> Registers => Set<Register>();
    public DbSet<Station> Stations => Set<Station>();
    public DbSet<Part> Part => Set<Part>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PSDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}