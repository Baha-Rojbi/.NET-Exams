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
    internal class ConfigurationFluentApi : IEntityTypeConfiguration<RDV>
    {
        public void Configure(EntityTypeBuilder<RDV> builder)
        {
            builder.HasKey(r => new { r.DateRDV, r.ClientFk, r.PrestationFK });
            builder.HasOne(r => r.Prestation).WithMany(p => p.RDVs).HasForeignKey(f => f.PrestationFK);
            builder.HasOne(r => r.Client).WithMany(c => c.RDVs).HasForeignKey(fk => fk.ClientFk);
        }
    }
}
