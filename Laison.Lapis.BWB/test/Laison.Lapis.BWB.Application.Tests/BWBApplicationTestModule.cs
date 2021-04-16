using Laison.Lapis.BWB.Application;
using Volo.Abp.Modularity;

namespace Laison.Lapis.BWB
{
    [DependsOn(
        typeof(LapisBWBApplicationModule),
        typeof(BWBDomainTestModule)
        )]
    public class BWBApplicationTestModule : AbpModule
    {

    }
}
