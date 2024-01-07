using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class SinistreConfiguration : IEntityTypeConfiguration<Sinistre>
    {
        public void Configure(EntityTypeBuilder<Sinistre> builder)
        {
            builder.HasOne(p => p.Assurance)
                            .WithMany(p => p.ListeSinistres)
                            .HasForeignKey(p => p.AssuranceFk)
                            .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
