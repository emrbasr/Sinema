using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sinema.Dal.Migrations
{
    /// <inheritdoc />
    public partial class initDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kategoriler_Gosterimler_GosterimId",
                table: "Kategoriler");

            migrationBuilder.DropIndex(
                name: "IX_Kategoriler_GosterimId",
                table: "Kategoriler");

            migrationBuilder.DropColumn(
                name: "GosterimId",
                table: "Kategoriler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GosterimId",
                table: "Kategoriler",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_GosterimId",
                table: "Kategoriler",
                column: "GosterimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kategoriler_Gosterimler_GosterimId",
                table: "Kategoriler",
                column: "GosterimId",
                principalTable: "Gosterimler",
                principalColumn: "Id");
        }
    }
}
