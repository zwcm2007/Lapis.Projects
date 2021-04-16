using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Laison.Lapis.BWB.EntityFrameworkCore
{
    public class BWBHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<BWBHttpApiHostMigrationsDbContext>
    {
        public BWBHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var connStr = configuration.GetConnectionString("BWB");
            var builder = new DbContextOptionsBuilder<BWBHttpApiHostMigrationsDbContext>()
                .UseMySql(connStr, ServerVersion.AutoDetect(connStr));

            return new BWBHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}