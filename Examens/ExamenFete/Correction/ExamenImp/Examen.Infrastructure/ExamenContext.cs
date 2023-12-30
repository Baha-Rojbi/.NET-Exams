
using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure
{
    public class ExamenContext:DbContext
    {
        public DbSet<Fete> Fetes { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<Salle> Salles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); 

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                       Initial Catalog= FeteAbirHbecha;
                       Integrated Security=true;MultipleActiveResultSets=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Fete>().HasMany(p => p.Invitations)
                  .WithOne(p => p.Fete).HasForeignKey(p => p.FeteFk);


            modelBuilder.Entity<Invite>().HasMany(p => p.Invitations)
                 .WithOne(p => p.Invite).HasForeignKey(p => p.InviteFk);

            modelBuilder.Entity<Invitation>().HasKey(p => new
            {
                p.FeteFk,
                p.InviteFk,
                p.DateInvitation
            });


        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }
    }
}
