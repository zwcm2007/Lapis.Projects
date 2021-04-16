using Microsoft.Extensions.DependencyInjection;
using Laison.Lapis.BWB.Application.Contracts;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Laison.Lapis.BWB.HttpApi
{
    [DependsOn(
        typeof(LapisBWBApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class LapisBWBHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(LapisBWBHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}