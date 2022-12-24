using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebProje.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aktorler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilFotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biyografi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktorler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sinemalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinemalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yapimcilar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilFotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biyografi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yapimcilar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    AfisURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kategori = table.Column<int>(type: "int", nullable: false),
                    SinemaId = table.Column<int>(type: "int", nullable: false),
                    YapimciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmler_Sinemalar_SinemaId",
                        column: x => x.SinemaId,
                        principalTable: "Sinemalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Filmler_Yapimcilar_YapimciId",
                        column: x => x.YapimciId,
                        principalTable: "Yapimcilar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aktor_Filmler",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    AktorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktor_Filmler", x => new { x.AktorId, x.FilmId });
                    table.ForeignKey(
                        name: "FK_Aktor_Filmler_Aktorler_AktorId",
                        column: x => x.AktorId,
                        principalTable: "Aktorler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aktor_Filmler_Filmler_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Filmler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aktor_Filmler_FilmId",
                table: "Aktor_Filmler",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_SinemaId",
                table: "Filmler",
                column: "SinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_YapimciId",
                table: "Filmler",
                column: "YapimciId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aktor_Filmler");

            migrationBuilder.DropTable(
                name: "Aktorler");

            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "Sinemalar");

            migrationBuilder.DropTable(
                name: "Yapimcilar");
        }
    }
}
