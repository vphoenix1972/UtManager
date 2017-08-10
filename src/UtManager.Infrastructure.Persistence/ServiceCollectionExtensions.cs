using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UtManager.Core.Persistence;
using UtManager.Infrastructure.Persistence.Repositories;

namespace UtManager.Infrastructure.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUtManagerPersistence(this IServiceCollection services)
        {
            services.AddDbContext<UtManagerDbContext>(
                options => options.UseNpgsql(
                    Constants.ConnectionString)
            );

            services.AddTransient<IPlayersRepository, PlayersRepository>();
            services.AddTransient<IDatabaseService, DatabaseService>();
        }
    }
}