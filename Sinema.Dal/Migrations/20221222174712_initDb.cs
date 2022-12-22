using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinema.Dal.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gosterimler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gosterimler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sure = table.Column<int>(type: "int", nullable: false),
                    GosterimId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmler_Gosterimler_GosterimId",
                        column: x => x.GosterimId,
                        principalTable: "Gosterimler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Haftalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaftaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Baslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GosterimId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haftalar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haftalar_Gosterimler_GosterimId",
                        column: x => x.GosterimId,
                        principalTable: "Gosterimler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GosterimId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kategoriler_Gosterimler_GosterimId",
                        column: x => x.GosterimId,
                        principalTable: "Gosterimler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Salonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalonAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kapasite = table.Column<int>(type: "int", nullable: false),
                    GosterimId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salonlar_Gosterimler_GosterimId",
                        column: x => x.GosterimId,
                        principalTable: "Gosterimler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Seanslar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeansAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GosterimId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KullaniciId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seanslar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seanslar_Gosterimler_GosterimId",
                        column: x => x.GosterimId,
                        principalTable: "Gosterimler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FilmKategori",
                columns: table => new
                {
                    FilmlerId = table.Column<int>(type: "int", nullable: false),
                    KategorilerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmKategori", x => new { x.FilmlerId, x.KategorilerId });
                    table.ForeignKey(
                        name: "FK_FilmKategori_Filmler_FilmlerId",
                        column: x => x.FilmlerId,
                        principalTable: "Filmler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmKategori_Kategoriler_KategorilerId",
                        column: x => x.KategorilerId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmKategori_KategorilerId",
                table: "FilmKategori",
                column: "KategorilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_GosterimId",
                table: "Filmler",
                column: "GosterimId");

            migrationBuilder.CreateIndex(
                name: "IX_Haftalar_GosterimId",
                table: "Haftalar",
                column: "GosterimId");

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_GosterimId",
                table: "Kategoriler",
                column: "GosterimId");

            migrationBuilder.CreateIndex(
                name: "IX_Salonlar_GosterimId",
                table: "Salonlar",
                column: "GosterimId");

            migrationBuilder.CreateIndex(
                name: "IX_Seanslar_GosterimId",
                table: "Seanslar",
                column: "GosterimId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmKategori");

            migrationBuilder.DropTable(
                name: "Haftalar");

            migrationBuilder.DropTable(
                name: "Salonlar");

            migrationBuilder.DropTable(
                name: "Seanslar");

            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Gosterimler");
        }
    }
}
