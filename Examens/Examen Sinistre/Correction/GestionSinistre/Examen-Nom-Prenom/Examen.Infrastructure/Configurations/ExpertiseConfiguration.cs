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
    public class ExpertiseConfiguration : IEntityTypeConfiguration<Expertise>
    {
        public void Configure(EntityTypeBuilder<Expertise> builder)
        {
            builder.HasOne(p => p.MySinistre).WithMany(p => p.Expertises).HasForeignKey(p => p.SinistreFk);
            builder.HasOne(p => p.Expert).WithMany(p => p.Expertises).HasForeignKey(p => p.ExpertFk);

            builder.HasKey(p => new
            {
                p.ExpertFk,
                p.SinistreFk,
                p.DateExpertise
            });
           


        }
    }
}
