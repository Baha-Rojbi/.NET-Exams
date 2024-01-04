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
    public class AdmissionConfiguration:IEntityTypeConfiguration<Admission>
    {
        public void Configure(EntityTypeBuilder<Admission> builder)
        {
            builder.HasKey(a => new { a.ChambreFk, a.PatientFk, a.DateAdmission });
            builder.HasOne(a => a.Chambre).WithMany(ch => ch.Admissions).HasForeignKey(a => a.ChambreFk);
            builder.HasOne(a => a.Patient).WithMany(p => p.Admissions).HasForeignKey(a => a.PatientFk);
        }
    }
}
