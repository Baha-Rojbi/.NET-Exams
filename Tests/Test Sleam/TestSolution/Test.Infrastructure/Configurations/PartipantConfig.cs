using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Test.ApplicationCore.Domain;

namespace Test.Infrastructure.Configurations
{
    public class PartipantConfig : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {
            builder.HasDiscriminator<Char>("TypeParticipant").HasValue<Participant>('P')
                .HasValue<Universitaire>('U')
                .HasValue<Industriel>('I');
        }
    }
}
