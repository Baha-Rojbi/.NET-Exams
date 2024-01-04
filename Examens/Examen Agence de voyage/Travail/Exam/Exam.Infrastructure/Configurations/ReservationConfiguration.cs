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
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasOne(r => r.Pack).WithMany(p => p.Reservations).HasForeignKey(r => r.PackFk);
            builder.HasOne(r => r.Client).WithMany(c => c.Reservations).HasForeignKey(r => r.ClientFk);
            builder.HasKey(r => new { r.ClientFk, r.PackFk, r.DateReservation });
        }
    }
}
