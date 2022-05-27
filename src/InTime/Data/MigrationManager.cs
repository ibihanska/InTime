using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace InTime.Data
{
    public static class MigrationManager
    {
        private static readonly ILogger _logger;

        public static IHost MigrateDatabase(this IHost host)
        {
             using(var scope = host.Services.CreateScope())
             {
                 using(var appContext = scope.ServiceProvider
                    .GetRequiredService<TrelloCloneDbContext>())
                 {
                    appContext.Database.Migrate();
                }
             }

            return host;
        }
    }
}
