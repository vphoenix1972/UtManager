using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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
        }
    }
}