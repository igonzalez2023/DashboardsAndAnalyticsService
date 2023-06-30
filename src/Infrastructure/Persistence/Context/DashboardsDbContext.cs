using Atos.Core.Commons;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context;

public class DashboardsDbContext : DbContext
{
    public DashboardsDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ReportBase> ReportBase { get; set; }
    public DbSet<ReportData> ReportData { get; set; }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in base.ChangeTracker.Entries<EntityBaseAuditable<Guid, Guid>>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.Id = Guid.NewGuid();
                    entry.Entity.CreatedDate = DateTime.UtcNow;
                    entry.Entity.State = true;
                    break;
                case EntityState.Modified:
                    entry.Entity.DateLastModify = DateTime.UtcNow;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DashboardsDbContext).Assembly);
    }
}