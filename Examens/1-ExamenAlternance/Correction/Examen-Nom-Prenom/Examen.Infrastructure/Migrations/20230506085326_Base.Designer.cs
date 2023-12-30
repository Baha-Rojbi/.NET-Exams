﻿// <auto-generated />
using System;
using Examen.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    [DbContext(typeof(ExamContext))]
    [Migration("20230506085326_Base")]
    partial class Base
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Categorie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Fournisseur", b =>
                {
                    b.Property<int>("Identifiant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Identifiant"));

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<int>("Nbr")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Identifiant");

                    b.ToTable("Fournisseurs");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Produit", b =>
                {
                    b.Property<int>("ProduitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProduitId"));

                    b.Property<int>("CategorieFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateProd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("TypeProduit")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("ProduitId");

                    b.HasIndex("CategorieFk");

                    b.ToTable("Produits");

                    b.HasDiscriminator<string>("TypeProduit").HasValue("P");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("FournisseurProduit", b =>
                {
                    b.Property<int>("FournisseursIdentifiant")
                        .HasColumnType("int");

                    b.Property<int>("ProduitsProduitId")
                        .HasColumnType("int");

                    b.HasKey("FournisseursIdentifiant", "ProduitsProduitId");

                    b.HasIndex("ProduitsProduitId");

                    b.ToTable("Facture", (string)null);
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Biologique", b =>
                {
                    b.HasBaseType("Examen.ApplicationCore.Domain.Produit");

                    b.Property<string>("Composition")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("B");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Chimique", b =>
                {
                    b.HasBaseType("Examen.ApplicationCore.Domain.Produit");

                    b.Property<string>("NomLab")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasDiscriminator().HasValue("C");
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Produit", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Categorie", "Categorie")
                        .WithMany("Produits")
                        .HasForeignKey("CategorieFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("FournisseurProduit", b =>
                {
                    b.HasOne("Examen.ApplicationCore.Domain.Fournisseur", null)
                        .WithMany()
                        .HasForeignKey("FournisseursIdentifiant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.ApplicationCore.Domain.Produit", null)
                        .WithMany()
                        .HasForeignKey("ProduitsProduitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Examen.ApplicationCore.Domain.Categorie", b =>
                {
                    b.Navigation("Produits");
                });
#pragma warning restore 612, 618
        }
    }
}
