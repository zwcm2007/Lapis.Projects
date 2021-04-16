using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Volo.Abp.VirtualFileSystem;

namespace Laison.Lapis.BWB.Domain.Shared
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class LapisBWBDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<LapisBWBDomainSharedModule>();
            });
        }
    }
}