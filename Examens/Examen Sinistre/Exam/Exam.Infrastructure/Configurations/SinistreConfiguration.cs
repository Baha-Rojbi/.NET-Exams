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
    public class SinistreConfiguration:IEntityTypeConfiguration<Sinistre>
    {
        public void Configure(EntityTypeBuilder<Sinistre> builder)
        {
            builder.HasOne(s => s.Assurance).WithMany(a => a.Sinistres).HasForeignKey(s => s.AssuranceFk);
        }
    }
}
