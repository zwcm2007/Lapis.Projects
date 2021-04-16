using Microsoft.EntityFrameworkCore;
using Laison.Lapis.BWB.Domain;
using Laison.Lapis.BWB.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.BWB.EntityFrameworkCore
{
    [ConnectionStringName(BWBDbProperties.ConnectionStringName)]
    public class BWBDbContext : AbpDbContext<BWBDbContext>, IBWBDbContext
    {
        // Add DbSet for each Aggregate Root
        public DbSet<Order> Orders { get; set; }  // Todo: get or set ?

        public BWBDbContext(DbContextOptions<BWBDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureBWB();
        }
    }
}