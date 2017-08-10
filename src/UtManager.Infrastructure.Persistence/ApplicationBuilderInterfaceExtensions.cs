using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace UtManager.Infrastructure.Persistence
{
    public static class ApplicationBuilderInterfaceExtensions
    {
        public static void ApplyDatabaseMigrations(this IApplicationBuilder app)
        {
            var db = app.ApplicationServices.GetService<UtManagerDbContext>();
            if (db == null)
                throw new InvalidOperationException(
                    $"Service '{nameof(UtManagerDbContext)}' must be added in service container.");

            db.Migrate();
        }
    }
}