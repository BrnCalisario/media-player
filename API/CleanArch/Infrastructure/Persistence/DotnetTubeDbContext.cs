using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class DotnetTubeDbContext : DbContext
{
    public DotnetTubeDbContext(DbContextOptions<DotnetTubeDbContext> options) 
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DotnetTubeDbContext).Assembly);
    }
}