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
    public class ExpertiseConfiguration:IEntityTypeConfiguration<Expertise>
    {
        public void Configure(EntityTypeBuilder<Expertise> builder)
        {
            builder.HasOne(e => e.Expert).WithMany(e => e.Expertises).HasForeignKey(e => e.ExpertFk);
            builder.HasOne(e => e.Sinistre).WithMany(s => s.Expertises).HasForeignKey(e => e.SinistreFk);
            builder.HasKey(e => new { e.ExpertFk, e.SinistreFk, e.DateExpertise });
        }
    }
}
