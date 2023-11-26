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
    public class TestContext :DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=BahaRojbi4GL;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Cagnotte> Cagnottes { get; set; }
        public DbSet<Entreprise> Entreprisees { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Participation> Participations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FluentApi());
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties()
                             .Where(p => p.ClrType == typeof(string) && p.Name.StartsWith("Mail")))
                {
                    property.IsNullable = false;
                }
            }



        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {

           
        }
    }
}
