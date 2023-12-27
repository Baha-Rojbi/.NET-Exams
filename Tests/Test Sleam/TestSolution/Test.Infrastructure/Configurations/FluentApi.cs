using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.ApplicationCore.Domain;

namespace Test.Infrastructure.Configurations
{
    public class FluentApi : IEntityTypeConfiguration<Inscription>
    {
        public void Configure(EntityTypeBuilder<Inscription> builder)
        {
            builder.HasOne(i => i.Seminaire).WithMany(s => s.Inscriptions).HasForeignKey(f => f.SeminaireFk);
            builder.HasOne(i => i.Participant).WithMany(p => p.Inscriptions).HasForeignKey(f => f.ParticipantFk);
            builder.HasKey(i => new { i.DateInscription, i.ParticipantFk, i.SeminaireFk });
        }
    }
}
