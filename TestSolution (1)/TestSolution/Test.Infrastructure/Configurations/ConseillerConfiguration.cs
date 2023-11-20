using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.ApplicationCore.Domain;

namespace Test.Infrastructure.Configurations
{
    internal class ConseillerConfiguration:IEntityTypeConfiguration<Conseiller>
    {
        public void Configure(EntityTypeBuilder<Conseiller> builder)
        {
            builder.HasMany(c => c.Clients).WithOne(cl => cl.Conseiller).HasForeignKey(cl => cl.ConseillerFk)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
