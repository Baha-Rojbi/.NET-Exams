using Exam.CoreApplication.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Infrastructure.Configurations;

namespace Exam.Infrastructure
{
    public class ExamContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<Chambre> Chambres { get; set; }
        public DbSet<Clinique> Cliniques { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=CliniqueDB;Integrated Security=true; MultipleActiveResultSets = true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdmissionConfiguration());
            modelBuilder.ApplyConfiguration(new ChambreConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //modelBuilder.ApplyConfiguration(new TicketConfiguration());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //configurationBuilder.Properties<DateTime>().HaveColumnType("date");

            //configurationBuilder.Properties<String>().HaveMaxLength(50);
        }

    }
}