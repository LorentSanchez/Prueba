using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba.Web.Migrations
{
    public partial class preuba3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Articles_ArticlesId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassificationArt_Articles_ArticlesId",
                table: "ClassificationArt");

            migrationBuilder.DropColumn(
                name: "TypeArticles",
                table: "Articles");

            migrationBuilder.AlterColumn<int>(
                name: "ArticlesId",
                table: "ClassificationArt",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ArticlesId",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Articles_ArticlesId",
                table: "Brand",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "ArticlesId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassificationArt_Articles_ArticlesId",
                table: "ClassificationArt",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "ArticlesId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Articles_ArticlesId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassificationArt_Articles_ArticlesId",
                table: "ClassificationArt");

            migrationBuilder.AlterColumn<int>(
                name: "ArticlesId",
                table: "ClassificationArt",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArticlesId",
                table: "Brand",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypeArticles",
                table: "Articles",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_Articles_ArticlesId",
                table: "Brand",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "ArticlesId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassificationArt_Articles_ArticlesId",
                table: "ClassificationArt",
                column: "ArticlesId",
                principalTable: "Articles",
                principalColumn: "ArticlesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
