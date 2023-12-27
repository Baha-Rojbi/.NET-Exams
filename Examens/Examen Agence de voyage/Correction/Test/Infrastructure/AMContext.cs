using ApplicationCore.Domain;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AM.Infrastructure
{
    public class AMContext: DbContext
    {

        public DbSet<Client> Clients { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=TestBD;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //    // Pre-convention model configuration goes here
            configurationBuilder
                .Properties<string>()
                .HaveMaxLength(15);




        }



    }
}
