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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=BeautyBahaRojbi;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<RDV> RDVs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigurationFluentApi());
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<String>().HaveMaxLength(150);
            //configurationBuilder.Properties<String>().HaveMaxLength(30);
        }
    }
}
