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
    public class ConseillerConfiguration:IEntityTypeConfiguration<Conseiller>

    {
        public void Configure(EntityTypeBuilder<Conseiller> builder)
        {
            builder.HasMany(c => c.Clients).WithOne(cl => cl.Conseiller).HasForeignKey(cl => cl.ConseillerFk)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
