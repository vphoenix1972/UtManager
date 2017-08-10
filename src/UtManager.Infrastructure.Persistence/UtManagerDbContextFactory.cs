using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace UtManager.Infrastructure.Persistence
{
    internal class UtManagerDbContextFactory : IDbContextFactory<UtManagerDbContext>
    {
        public UtManagerDbContext Create(DbContextFactoryOptions options)
        {
            var builderOption = new DbContextOptionsBuilder<UtManagerDbContext>();

            builderOption.UseNpgsql(Constants.ConnectionString,
                o => o.MigrationsAssembly("UtManager.Infrastructure.Persistence"));

            return new UtManagerDbContext(builderOption.Options);
        }
    }
}