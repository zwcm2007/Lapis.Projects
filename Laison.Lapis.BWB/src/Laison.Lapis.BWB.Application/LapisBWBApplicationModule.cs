using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Laison.Lapis.BWB.Domain;
using Laison.Lapis.BWB.Application.Contracts;

namespace Laison.Lapis.BWB.Application
{
    [DependsOn(
        typeof(LapisBWBDomainModule),
        typeof(LapisBWBApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class LapisBWBApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<LapisBWBApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<LapisBWBApplicationModule>(validate: true);
            });
        }
    }
}
