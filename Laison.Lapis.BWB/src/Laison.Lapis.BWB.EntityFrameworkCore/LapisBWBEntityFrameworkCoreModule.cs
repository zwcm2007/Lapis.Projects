using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.BWB.Domain;
using Laison.Lapis.BWB.Domain.Entities;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.BWB.EntityFrameworkCore
{
    [DependsOn(
        typeof(LapisBWBDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class LapisBWBEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<BWBDbContext>(options =>
            {
                options.AddDefaultRepositories(includeAllEntities: true);

                // Add custom repositories
                options.AddRepository<Order, OrderRepository>();
            });
        }
    }
}