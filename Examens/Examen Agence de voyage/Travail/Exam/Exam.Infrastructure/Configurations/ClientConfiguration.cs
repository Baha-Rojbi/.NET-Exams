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
    public class ClientConfiguration:IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasOne(cl => cl.Conseiller).WithMany(co => co.Clients).HasForeignKey(cl => cl.ConseillerFk)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
