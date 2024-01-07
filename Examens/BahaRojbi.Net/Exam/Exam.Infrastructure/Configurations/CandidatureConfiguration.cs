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
    public class CandidatureConfiguration:IEntityTypeConfiguration<Candidature>
    {
        public void Configure(EntityTypeBuilder<Candidature> builder)
        {
            builder.HasOne(ca => ca.Concours).WithMany(co => co.Candidatures).HasForeignKey(ca => ca.ConcoursFk);
            builder.HasOne(ca => ca.Enseignant).WithMany(e => e.Candidatures).HasForeignKey(ca => ca.EnseignantFk);
            builder.HasKey(ca => new { ca.ConcoursFk, ca.EnseignantFk, ca.DateDepot });

        }
    }
}
