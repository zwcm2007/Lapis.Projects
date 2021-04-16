using Microsoft.EntityFrameworkCore;
using Laison.Lapis.BWB.Domain;
using Laison.Lapis.BWB.Domain.Entities;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Laison.Lapis.BWB.EntityFrameworkCore
{
    [ConnectionStringName(BWBDbProperties.ConnectionStringName)]
    public interface IBWBDbContext : IEfCoreDbContext
    {
        // Add DbSet for each Aggregate Root
        DbSet<Order> Orders { get; }
        
    }
}
