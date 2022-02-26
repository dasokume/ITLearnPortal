using IT.Learn.Portal.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace IT.Learn.Portal.Persistence
{
    public class ITLearnPortalDbContext : DbContext
    {
        public ITLearnPortalDbContext(DbContextOptions<ITLearnPortalDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ITLearnPortalDbContext).Assembly);

            // TODO: Add some seed data
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedDate = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}