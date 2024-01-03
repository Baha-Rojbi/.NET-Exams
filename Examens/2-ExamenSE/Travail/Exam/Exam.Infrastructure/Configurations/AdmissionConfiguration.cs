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
            builder.HasOne(a => a.Patient).WithMany(p => p.Admissions).HasForeignKey(a => a.PatientFk);
            builder.HasOne(a => a.Chambre).WithMany(c => c.Admissions).HasForeignKey(a => a.ChambreFk);
            builder.HasKey(a => new { a.ChambreFk, a.PatientFk, a.DateAdmission });
        }
    }
}
