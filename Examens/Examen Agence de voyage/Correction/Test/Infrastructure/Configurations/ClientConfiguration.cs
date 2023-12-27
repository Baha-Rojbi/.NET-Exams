﻿using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasOne(c=>c.Conseiller)
                .WithMany(l=>l.Clients)
                .HasForeignKey(c=>c.ConseillerFK)
                .OnDelete(DeleteBehavior.Cascade);
            
        }
    }
}
