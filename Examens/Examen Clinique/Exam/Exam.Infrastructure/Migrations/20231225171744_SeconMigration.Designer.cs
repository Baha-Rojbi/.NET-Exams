﻿// <auto-generated />
using System;
using Exam.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exam.Infrastructure.Migrations
{
    [DbContext(typeof(ExamContext))]
    [Migration("20231225171744_SeconMigration")]
    partial class SeconMigration
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

            modelBuilder.Entity("Exam.CoreApplication.Domain.Admission", b =>
                {
                    b.Property<int>("ChambreFk")
                        .HasColumnType("int");

                    b.Property<int>("PatientFk")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdmission")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotifAdmission")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NbJours")
                        .HasColumnType("int");

                    b.HasKey("ChambreFk", "PatientFk", "DateAdmission");

                    b.HasIndex("PatientFk");

                    b.ToTable("Admissions");
                });

            modelBuilder.Entity("Exam.CoreApplication.Domain.Chambre", b =>
                {
                    b.Property<int>("NumeroChambre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumeroChambre"));

                    b.Property<int>("CLiniqueFk")
                        .HasColumnType("int");

                    b.Property<float>("Prix")
                        .HasColumnType("real");

                    b.Property<int>("TypeChambre")
                        .HasColumnType("int");

                    b.HasKey("NumeroChambre");

                    b.HasIndex("CLiniqueFk");

                    b.ToTable("Chambres");
                });

            modelBuilder.Entity("Exam.CoreApplication.Domain.Clinique", b =>
                {
                    b.Property<int>("CliniqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CliniqueId"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacite")
                        .HasColumnType("int");

                    b.Property<int>("NumTel")
                        .HasColumnType("int");

                    b.HasKey("CliniqueId");

                    b.ToTable("Cliniques");
                });

            modelBuilder.Entity("Exam.CoreApplication.Domain.Patient", b =>
                {
                    b.Property<int>("NumDossier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumDossier"));

                    b.Property<string>("AdresseEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumTel")
                        .HasColumnType("int");

                    b.HasKey("NumDossier");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Exam.CoreApplication.Domain.Admission", b =>
                {
                    b.HasOne("Exam.CoreApplication.Domain.Chambre", "Chambre")
                        .WithMany("Admissions")
                        .HasForeignKey("ChambreFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Exam.CoreApplication.Domain.Patient", "Patient")
                        .WithMany("Admissions")
                        .HasForeignKey("PatientFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chambre");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Exam.CoreApplication.Domain.Chambre", b =>
                {
                    b.HasOne("Exam.CoreApplication.Domain.Clinique", "Clinique")
                        .WithMany("Chambres")
                        .HasForeignKey("CLiniqueFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinique");
                });

            modelBuilder.Entity("Exam.CoreApplication.Domain.Patient", b =>
                {
                    b.OwnsOne("Exam.CoreApplication.Domain.NomComplet", "NomComplet", b1 =>
                        {
                            b1.Property<int>("PatientNumDossier")
                                .HasColumnType("int");

                            b1.Property<string>("Nom")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Prenom")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PatientNumDossier");

                            b1.ToTable("Patients");

                            b1.WithOwner()
                                .HasForeignKey("PatientNumDossier");
                        });

                    b.Navigation("NomComplet")
                        .IsRequired();
                });

            modelBuilder.Entity("Exam.CoreApplication.Domain.Chambre", b =>
                {
                    b.Navigation("Admissions");
                });

            modelBuilder.Entity("Exam.CoreApplication.Domain.Clinique", b =>
                {
                    b.Navigation("Chambres");
                });

            modelBuilder.Entity("Exam.CoreApplication.Domain.Patient", b =>
                {
                    b.Navigation("Admissions");
                });
#pragma warning restore 612, 618
        }
    }
}
