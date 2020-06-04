using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba.Web.Migrations
{
    public partial class preuba6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Owners_IdDocumet",
                table: "Owners");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_IdDocumet",
                table: "Owners",
                column: "IdDocumet",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Owners_IdDocumet",
                table: "Owners");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_IdDocumet",
                table: "Owners",
                column: "IdDocumet");
        }
    }
}
