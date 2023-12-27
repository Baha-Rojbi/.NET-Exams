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
        }
    }
}
