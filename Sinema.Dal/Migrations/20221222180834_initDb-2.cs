using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinema.Dal.Migrations
{
    /// <inheritdoc />
    public partial class initDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmler_Gosterimler_GosterimId",
                table: "Filmler");

            migrationBuilder.DropForeignKey(
                name: "FK_Haftalar_Gosterimler_GosterimId",
                table: "Haftalar");

            migrationBuilder.DropForeignKey(
                name: "FK_Salonlar_Gosterimler_GosterimId",
                table: "Salonlar");

            migrationBuilder.DropForeignKey(
                name: "FK_Seanslar_Gosterimler_GosterimId",
                table: "Seanslar");

            migrationBuilder.DropIndex(
                name: "IX_Seanslar_GosterimId",
                table: "Seanslar");

            migrationBuilder.DropIndex(
                name: "IX_Salonlar_GosterimId",
                table: "Salonlar");

            migrationBuilder.DropIndex(
                name: "IX_Haftalar_GosterimId",
                table: "Haftalar");

            migrationBuilder.DropIndex(
                name: "IX_Filmler_GosterimId",
                table: "Filmler");

            migrationBuilder.DropColumn(
                name: "GosterimId",
                table: "Seanslar");

            migrationBuilder.DropColumn(
                name: "GosterimId",
                table: "Salonlar");

            migrationBuilder.DropColumn(
                name: "GosterimId",
                table: "Haftalar");

            migrationBuilder.DropColumn(
                name: "GosterimId",
                table: "Filmler");

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Gosterimler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hafta",
                table: "Gosterimler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HaftalarId",
                table: "Gosterimler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Gosterimler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalonId",
                table: "Gosterimler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeansId",
                table: "Gosterimler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Gosterimler_FilmId",
                table: "Gosterimler",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Gosterimler_HaftalarId",
                table: "Gosterimler",
                column: "HaftalarId");

            migrationBuilder.CreateIndex(
                name: "IX_Gosterimler_KategoriId",
                table: "Gosterimler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Gosterimler_SalonId",
                table: "Gosterimler",
                column: "SalonId");

            migrationBuilder.CreateIndex(
                name: "IX_Gosterimler_SeansId",
                table: "Gosterimler",
                column: "SeansId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Filmler_FilmId",
                table: "Gosterimler",
                column: "FilmId",
                principalTable: "Filmler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Haftalar_HaftalarId",
                table: "Gosterimler",
                column: "HaftalarId",
                principalTable: "Haftalar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Kategoriler_KategoriId",
                table: "Gosterimler",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Salonlar_SalonId",
                table: "Gosterimler",
                column: "SalonId",
                principalTable: "Salonlar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Seanslar_SeansId",
                table: "Gosterimler",
                column: "SeansId",
                principalTable: "Seanslar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Filmler_FilmId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Haftalar_HaftalarId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Kategoriler_KategoriId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Salonlar_SalonId",
                table: "Gosterimler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Seanslar_SeansId",
                table: "Gosterimler");

            migrationBuilder.DropIndex(
                name: "IX_Gosterimler_FilmId",
                table: "Gosterimler");

            migrationBuilder.DropIndex(
                name: "IX_Gosterimler_HaftalarId",
                table: "Gosterimler");

            migrationBuilder.DropIndex(
                name: "IX_Gosterimler_KategoriId",
                table: "Gosterimler");

            migrationBuilder.DropIndex(
                name: "IX_Gosterimler_SalonId",
                table: "Gosterimler");

            migrationBuilder.DropIndex(
                name: "IX_Gosterimler_SeansId",
                table: "Gosterimler");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Gosterimler");

            migrationBuilder.DropColumn(
                name: "Hafta",
                table: "Gosterimler");

            migrationBuilder.DropColumn(
                name: "HaftalarId",
                table: "Gosterimler");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Gosterimler");

            migrationBuilder.DropColumn(
                name: "SalonId",
                table: "Gosterimler");

            migrationBuilder.DropColumn(
                name: "SeansId",
                table: "Gosterimler");

            migrationBuilder.AddColumn<int>(
                name: "GosterimId",
                table: "Seanslar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GosterimId",
                table: "Salonlar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GosterimId",
                table: "Haftalar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GosterimId",
                table: "Filmler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seanslar_GosterimId",
                table: "Seanslar",
                column: "GosterimId");

            migrationBuilder.CreateIndex(
                name: "IX_Salonlar_GosterimId",
                table: "Salonlar",
                column: "GosterimId");

            migrationBuilder.CreateIndex(
                name: "IX_Haftalar_GosterimId",
                table: "Haftalar",
                column: "GosterimId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_GosterimId",
                table: "Filmler",
                column: "GosterimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmler_Gosterimler_GosterimId",
                table: "Filmler",
                column: "GosterimId",
                principalTable: "Gosterimler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Haftalar_Gosterimler_GosterimId",
                table: "Haftalar",
                column: "GosterimId",
                principalTable: "Gosterimler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Salonlar_Gosterimler_GosterimId",
                table: "Salonlar",
                column: "GosterimId",
                principalTable: "Gosterimler",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seanslar_Gosterimler_GosterimId",
                table: "Seanslar",
                column: "GosterimId",
                principalTable: "Gosterimler",
                principalColumn: "Id");
        }
    }
}
