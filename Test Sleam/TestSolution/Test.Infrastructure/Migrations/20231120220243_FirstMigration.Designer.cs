﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Infrastructure;

#nullable disable

namespace Test.Infrastructure.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20231120220243_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Test.ApplicationCore.Domain.Inscription", b =>
                {
                    b.Property<DateTime>("DateInscription")
                        .HasColumnType("datetime2");

                    b.Property<int>("ParticipantFk")
                        .HasColumnType("int");

                    b.Property<int>("SeminaireFk")
                        .HasColumnType("int");

                    b.Property<double>("TaxReduction")
                        .HasColumnType("float");

                    b.HasKey("DateInscription", "ParticipantFk", "SeminaireFk");

                    b.HasIndex("ParticipantFk");

                    b.HasIndex("SeminaireFk");

                    b.ToTable("Inscriptions");
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumeroTelephone")
                        .HasColumnType("int");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TypeParticipant")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Participants");

                    b.HasDiscriminator<string>("TypeParticipant").HasValue("P");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Seminaire", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Code"));

                    b.Property<DateTime>("DateSemaine")
                        .HasColumnType("datetime2");

                    b.Property<string>("Intitule")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Lieu")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NombreMaximal")
                        .HasColumnType("int");

                    b.Property<double>("Tarif")
                        .HasColumnType("float");

                    b.HasKey("Code");

                    b.ToTable("Seminaires");
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Specialite", b =>
                {
                    b.Property<int>("SpecialiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialiteId"));

                    b.Property<string>("Abreviation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("SpecialiteId");

                    b.ToTable("Specialites");
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Industriel", b =>
                {
                    b.HasBaseType("Test.ApplicationCore.Domain.Participant");

                    b.Property<string>("Fonction")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NomEntreprise")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasDiscriminator().HasValue("I");
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Universitaire", b =>
                {
                    b.HasBaseType("Test.ApplicationCore.Domain.Participant");

                    b.Property<string>("Niveau")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NomInstitut")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SpecialiteFk")
                        .HasColumnType("int");

                    b.HasIndex("SpecialiteFk");

                    b.HasDiscriminator().HasValue("U");
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Inscription", b =>
                {
                    b.HasOne("Test.ApplicationCore.Domain.Participant", "Participant")
                        .WithMany("Inscriptions")
                        .HasForeignKey("ParticipantFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test.ApplicationCore.Domain.Seminaire", "Seminaire")
                        .WithMany("Inscriptions")
                        .HasForeignKey("SeminaireFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("Seminaire");
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Universitaire", b =>
                {
                    b.HasOne("Test.ApplicationCore.Domain.Specialite", "Specialite")
                        .WithMany("Universitaires")
                        .HasForeignKey("SpecialiteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialite");
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Participant", b =>
                {
                    b.Navigation("Inscriptions");
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Seminaire", b =>
                {
                    b.Navigation("Inscriptions");
                });

            modelBuilder.Entity("Test.ApplicationCore.Domain.Specialite", b =>
                {
                    b.Navigation("Universitaires");
                });
#pragma warning restore 612, 618
        }
    }
}
