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
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Test;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
         public DbSet<Activite> Activites { get; set; }
         public DbSet<Client> Clients { get; set; }
         public DbSet<Conseiller> Conseillers { get; set; }
         public DbSet<Pack> Packs { get; set; }
         public DbSet<Reservation> Reservations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.ApplyConfiguration(new ReservationConfiguration());
         }
         protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
         {
             configurationBuilder.Properties<String>().HaveMaxLength(15);
             //configurationBuilder.Properties<String>().HaveMaxLength(30);
         }
    }
}
