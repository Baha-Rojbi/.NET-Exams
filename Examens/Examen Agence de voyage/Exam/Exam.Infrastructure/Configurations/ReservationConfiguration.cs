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
    public class ReservationConfiguration:IEntityTypeConfiguration<Reservation>
    {
        public void Configure(  EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(r => new { r.DateReservation, r.ClientFk, r.PackFk });
        }
    }
}
