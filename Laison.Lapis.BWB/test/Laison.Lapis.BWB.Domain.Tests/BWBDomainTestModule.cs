using Laison.Lapis.BWB.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Laison.Lapis.BWB
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(BWBEntityFrameworkCoreTestModule)
        )]
    public class BWBDomainTestModule : AbpModule
    {
        
    }
}
