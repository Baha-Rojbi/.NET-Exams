using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assurances",
                columns: table => new
                {
                    AssuranceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateEffet = table.Column<DateTime>(type: "date", nullable: false),
                    DateEcheance = table.Column<DateTime>(type: "date", nullable: false),
                    TypeAssurance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assurances", x => x.AssuranceId);
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomaineExpertise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarifHoraire = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sinistres",
                columns: table => new
                {
                    SinistreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateDeclaration = table.Column<DateTime>(type: "date", nullable: false),
                    Lieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssuranceFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinistres", x => x.SinistreId);
                    table.ForeignKey(
                        name: "FK_Sinistres_Assurances_AssuranceFk",
                        column: x => x.AssuranceFk,
                        principalTable: "Assurances",
                        principalColumn: "AssuranceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expertises",
                columns: table => new
                {
                    DateExpertise = table.Column<DateTime>(type: "date", nullable: false),
                    SinistreFk = table.Column<int>(type: "int", nullable: false),
                    ExpertFk = table.Column<int>(type: "int", nullable: false),
                    AvisTechnique = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontantEstime = table.Column<double>(type: "float", nullable: false),
                    Duree = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertises", x => new { x.ExpertFk, x.SinistreFk, x.DateExpertise });
                    table.ForeignKey(
                        name: "FK_Expertises_Experts_ExpertFk",
                        column: x => x.ExpertFk,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Expertises_Sinistres_SinistreFk",
                        column: x => x.SinistreFk,
                        principalTable: "Sinistres",
                        principalColumn: "SinistreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expertises_SinistreFk",
                table: "Expertises",
                column: "SinistreFk");

            migrationBuilder.CreateIndex(
                name: "IX_Sinistres_AssuranceFk",
                table: "Sinistres",
                column: "AssuranceFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expertises");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Sinistres");

            migrationBuilder.DropTable(
                name: "Assurances");
        }
    }
}
