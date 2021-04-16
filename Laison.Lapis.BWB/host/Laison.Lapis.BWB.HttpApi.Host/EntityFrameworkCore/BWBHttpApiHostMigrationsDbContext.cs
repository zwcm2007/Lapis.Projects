using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.BWB.EntityFrameworkCore
{
    public class BWBHttpApiHostMigrationsDbContext : AbpDbContext<BWBHttpApiHostMigrationsDbContext>
    {
        public BWBHttpApiHostMigrationsDbContext(DbContextOptions<BWBHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureBWB();
        }
    }
}
