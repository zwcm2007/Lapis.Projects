using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Laison.Lapis.BWB.EntityFrameworkCore
{
    public class BWBModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public BWBModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}