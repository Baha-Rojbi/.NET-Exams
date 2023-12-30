using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class ProduitsConfiguration : IEntityTypeConfiguration<Produit>
    {
        public void Configure(EntityTypeBuilder<Produit> builder)
        {

            // config de la clé etran : 2 éme meth <=> [ForeignKey("")]
            builder.HasOne(p => p.Categorie)
                .WithMany(p => p.Produits)
                .HasForeignKey(p => p.CategorieFk)
                .OnDelete(DeleteBehavior.Cascade);

            // config de * *
            builder.HasMany(p => p.Fournisseurs)
                .WithMany(p => p.Produits)
                .UsingEntity(p => p.ToTable("Facture"));

            //TPH
            builder.HasDiscriminator<char>("TypeProduit")
                .HasValue<Produit>('P')
                .HasValue<Biologique>('B')
                .HasValue<Chimique>('C');



        }
    }
}
