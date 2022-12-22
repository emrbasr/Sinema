using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinema.Dal.Migrations
{
    /// <inheritdoc />
    public partial class initDb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gosterimler_Kategoriler_KategoriId",
                table: "Gosterimler");

            migrationBuilder.DropIndex(
                name: "IX_Gosterimler_KategoriId",
                table: "Gosterimler");

            migrationBuilder.DropColumn(
                name: "KategoriId",
                table: "Gosterimler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategoriId",
                table: "Gosterimler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Gosterimler_KategoriId",
                table: "Gosterimler",
                column: "KategoriId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gosterimler_Kategoriler_KategoriId",
                table: "Gosterimler",
                column: "KategoriId",
                principalTable: "Kategoriler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
