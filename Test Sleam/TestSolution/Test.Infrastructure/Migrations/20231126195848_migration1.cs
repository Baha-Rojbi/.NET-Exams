using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seminaires",
                columns: table => new
                {
                    Code = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Intitule = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Lieu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tarif = table.Column<double>(type: "float", nullable: false),
                    DateSemaine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NombreMaximal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seminaires", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Specialites",
                columns: table => new
                {
                    SpecialiteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abreviation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialites", x => x.SpecialiteId);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumeroTelephone = table.Column<int>(type: "int", nullable: false),
                    TypeParticipant = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Fonction = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NomEntreprise = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Niveau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NomInstitut = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SpecialiteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_Specialites_SpecialiteId",
                        column: x => x.SpecialiteId,
                        principalTable: "Specialites",
                        principalColumn: "SpecialiteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inscriptions",
                columns: table => new
                {
                    DateInscription = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeminaireFk = table.Column<int>(type: "int", nullable: false),
                    ParticipantFk = table.Column<int>(type: "int", nullable: false),
                    TauxReduction = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscriptions", x => new { x.DateInscription, x.ParticipantFk, x.SeminaireFk });
                    table.ForeignKey(
                        name: "FK_Inscriptions_Participants_ParticipantFk",
                        column: x => x.ParticipantFk,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inscriptions_Seminaires_SeminaireFk",
                        column: x => x.SeminaireFk,
                        principalTable: "Seminaires",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inscriptions_ParticipantFk",
                table: "Inscriptions",
                column: "ParticipantFk");

            migrationBuilder.CreateIndex(
                name: "IX_Inscriptions_SeminaireFk",
                table: "Inscriptions",
                column: "SeminaireFk");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_SpecialiteId",
                table: "Participants",
                column: "SpecialiteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscriptions");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Seminaires");

            migrationBuilder.DropTable(
                name: "Specialites");
        }
    }
}
