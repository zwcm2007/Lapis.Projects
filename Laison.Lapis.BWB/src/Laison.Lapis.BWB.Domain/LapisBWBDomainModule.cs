using Laison.Lapis.BWB.Domain.Shared;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Laison.Lapis.BWB.Domain
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(LapisBWBDomainSharedModule)
    )]
    public class LapisBWBDomainModule : AbpModule
    {

    }
}
