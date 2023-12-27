using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.CoreApplication.Domain;
using Exam.Infrastructure.Configurations;

namespace Exam.Infrastructure
{
    public class ExamContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
Initial Catalog=ExamenSinistre;Integrated Security=true; MultipleActiveResultSets = true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ExpertiseConfiguration());
            modelBuilder.ApplyConfiguration(new SinistreConfiguration());
            //modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            //modelBuilder.ApplyConfiguration(new TicketConfiguration());
        }
        public DbSet<Assurance> Assurances{ get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Expertise> Expertises { get; set; }
        public DbSet<Sinistre> Sinistres { get; set; }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");

            //configurationBuilder.Properties<String>().HaveMaxLength(50);
        }

    }
}