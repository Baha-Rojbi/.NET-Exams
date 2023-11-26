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
    public class FluentApi:IEntityTypeConfiguration<Participation>
    {
        public void Configure(EntityTypeBuilder<Participation> builder)
        {
            builder.HasOne(p => p.Cagnotte).WithMany(c => c.Participations).HasForeignKey(p => p.CagnotteFk);
            builder.HasOne(p => p.Participant).WithMany(p => p.Participations).HasForeignKey(p => p.ParticipantFk);
            builder.HasKey(p => new { p.CagnotteFk, p.ParticipantFk});

        }
    }
}
