using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Volo.Abp;

namespace Laison.Lapis.BWB.EntityFrameworkCore
{
    public static class BWBDbContextModelCreatingExtensions
    {
        public static void ConfigureBWB(
            this ModelBuilder builder,
            Action<BWBModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //var options = new BWBModelBuilderConfigurationOptions(
            //    BWBDbProperties.DbTablePrefix,
            //    BWBDbProperties.DbSchema
            //);

            //optionsAction?.Invoke(options);
        }
    }
}