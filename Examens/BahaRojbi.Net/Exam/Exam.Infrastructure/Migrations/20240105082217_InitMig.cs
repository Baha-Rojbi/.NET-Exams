using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concours",
                columns: table => new
                {
                    Promotion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NbrEM = table.Column<int>(type: "int", nullable: false),
                    NbrGC = table.Column<int>(type: "int", nullable: false),
                    NbrGED = table.Column<int>(type: "int", nullable: false),
                    NbrLANGUE = table.Column<int>(type: "int", nullable: false),
                    NbrMATH = table.Column<int>(type: "int", nullable: false),
                    NbrTIC = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concours", x => x.Promotion);
                });

            migrationBuilder.CreateTable(
                name: "UPs",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsable = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UPs", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Enseignants",
                columns: table => new
                {
                    Matricule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    Specialite = table.Column<int>(type: "int", nullable: false),
                    UPFk = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enseignants", x => x.Matricule);
                    table.ForeignKey(
                        name: "FK_Enseignants_UPs_UPFk",
                        column: x => x.UPFk,
                        principalTable: "UPs",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidatures",
                columns: table => new
                {
                    DateDepot = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnseignantFk = table.Column<int>(type: "int", nullable: false),
                    ConcoursFk = table.Column<int>(type: "int", nullable: false),
                    DateEntretien = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEpreuve = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dossier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resultat = table.Column<bool>(type: "bit", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatures", x => new { x.ConcoursFk, x.EnseignantFk, x.DateDepot });
                    table.ForeignKey(
                        name: "FK_Candidatures_Concours_ConcoursFk",
                        column: x => x.ConcoursFk,
                        principalTable: "Concours",
                        principalColumn: "Promotion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidatures_Enseignants_EnseignantFk",
                        column: x => x.EnseignantFk,
                        principalTable: "Enseignants",
                        principalColumn: "Matricule",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidatures_EnseignantFk",
                table: "Candidatures",
                column: "EnseignantFk");

            migrationBuilder.CreateIndex(
                name: "IX_Enseignants_UPFk",
                table: "Enseignants",
                column: "UPFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidatures");

            migrationBuilder.DropTable(
                name: "Concours");

            migrationBuilder.DropTable(
                name: "Enseignants");

            migrationBuilder.DropTable(
                name: "UPs");
        }
    }
}
