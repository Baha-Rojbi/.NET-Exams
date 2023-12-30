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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        //configuration de 1-* en utilisant FluentAPI

        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasOne(c => c.Conseiller)
                .WithMany(c => c.Clients)
                .HasForeignKey(c => c.ConseillerFk)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
