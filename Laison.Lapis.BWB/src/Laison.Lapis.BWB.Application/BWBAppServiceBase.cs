using Volo.Abp.Application.Services;

namespace Laison.Lapis.BWB.Application
{
    public abstract class BWBAppServiceBase : ApplicationService
    {
        protected BWBAppServiceBase()
        {
            ObjectMapperContext = typeof(LapisBWBApplicationModule);
        }
    }
}
