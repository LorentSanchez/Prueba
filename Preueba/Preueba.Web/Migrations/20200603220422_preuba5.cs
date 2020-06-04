using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba.Web.Migrations
{
    public partial class preuba5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypeDocument_Owners_OwnerId",
                table: "TypeDocument");

            migrationBuilder.DropColumn(
                name: "Document",
                table: "TypeDocument");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "TypeDocument",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeDocument_Owners_OwnerId",
                table: "TypeDocument",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypeDocument_Owners_OwnerId",
                table: "TypeDocument");

            migrationBuilder.AlterColumn<int>(
                name: "OwnerId",
                table: "TypeDocument",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Document",
                table: "TypeDocument",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_TypeDocument_Owners_OwnerId",
                table: "TypeDocument",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "OwnerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
