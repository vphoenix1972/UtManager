using Microsoft.EntityFrameworkCore;

namespace UtManager.Infrastructure.Persistence
{
    internal sealed class UtManagerDbContext : DbContext
    {
        public UtManagerDbContext(DbContextOptions<UtManagerDbContext> options) :
            base(options)
        {
        }

        public void Migrate()
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);
        }
    }
}