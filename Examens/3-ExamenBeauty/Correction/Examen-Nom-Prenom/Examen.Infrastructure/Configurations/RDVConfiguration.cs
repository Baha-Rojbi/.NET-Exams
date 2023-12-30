using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class RDVConfiguration : IEntityTypeConfiguration<RDV>
    {
        public void Configure(EntityTypeBuilder<RDV> builder)
        {
            //4-a
            //config de clientFK <=> [ForeignKey("ClientFk")]

            builder.HasOne(rdv => rdv.Client).WithMany(cl => cl.RDVs)
                .HasForeignKey(p => p.ClientFk)
                .OnDelete(DeleteBehavior.Cascade);
            //cofnig PrestationFK

            builder.HasOne(rdv => rdv.Prestation).WithMany(pre => pre.RDVs)
                .HasForeignKey(r => r.PrestationFk)
                .OnDelete(DeleteBehavior.Cascade);
            //4-b config de la clé composée

            builder.HasKey(rdv => new
            {
                rdv.PrestationFk,
                rdv.ClientFk,
                rdv.DateRDV
            }); ;


        }
    }
}
