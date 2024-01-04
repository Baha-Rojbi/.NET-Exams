using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.Infrastructure.Configurations
{
    public class RDVConfiguration:IEntityTypeConfiguration<RDV>
    {
        public void Configure(EntityTypeBuilder<RDV> builder)
        {
            builder.HasOne(r => r.Client).WithMany(c => c.RDVs).HasForeignKey(r => r.ClientFk);
            builder.HasOne(r => r.Prestation).WithMany(p => p.RDVs).HasForeignKey(r => r.PrestationFk);
            builder.HasKey(r => new { r.ClientFk, r.PrestationFk, r.DateRDV });
        }
    }
}
