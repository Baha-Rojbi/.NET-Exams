using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Infrastructure.Configurations;
using Exam.CoreApplication.Domain;

namespace Exam.Infrastructure
{
    public class ExamContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=ExamAgenceDeVoyage;Integrated Security=true; MultipleActiveResultSets = true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Activite> Activites { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Conseiller> Conseillers { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConseillerConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //modelBuilder.ApplyConfiguration(new TicketConfiguration());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //configurationBuilder.Properties<DateTime>().HaveColumnType("date");

            configurationBuilder.Properties<String>().HaveMaxLength(15);
        }

    }
}