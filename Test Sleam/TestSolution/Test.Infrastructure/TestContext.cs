using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test.ApplicationCore.Domain;
using Test.Infrastructure.Configurations;

namespace Test.Infrastructure
{
    public class TestContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=BahaRojbiOption;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Industriel> Industriels { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Seminaire>  Seminaires { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Universitaire> Universitaires { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigurationFluentApi());
            modelBuilder.ApplyConfiguration(new ConfigurationParticipant());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveMaxLength(100);
            //configurationBuilder.Properties<String>().HaveMaxLength(30);
        }
    }
}
