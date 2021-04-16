using Laison.Lapis.BWB.Domain.Shared;
using Volo.Abp.Application;
using Volo.Abp.Authorization;
using Volo.Abp.Modularity;

namespace Laison.Lapis.BWB.Application.Contracts
{
    [DependsOn(
        typeof(LapisBWBDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class LapisBWBApplicationContractsModule : AbpModule
    {
    }
}