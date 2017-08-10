using Microsoft.Extensions.DependencyInjection;
using UtManager.Core.Services;

namespace UtManager.Core
{
    public static class ServiceCollectionExtensions
    {
        public static void AddUtManagerCore(this IServiceCollection services)
        {
            services.AddTransient<IPlayersService, PlayersService>();
        }
    }
}