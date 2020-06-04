using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba.Web.Migrations
{
    public partial class preuba4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_Articles_ArticlesId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassificationArt_Articles_ArticlesId",
                table: "ClassificationArt");

            migrationBuilder.DropIndex(
                name: "IX_ClassificationArt_ArticlesId",
                table: "ClassificationArt");

            migrationBuilder.DropIndex(
                name: "IX_Brand_ArticlesId",
                table: "Brand");

            migrationBuilder.DropColumn(
                name: "ArticlesId",
                table: "ClassificationArt");

            migrationBuilder.DropColumn(
                name: "ArticlesId",
                table: "Brand");

            migrationBuilder.AddColumn<int>(
                name: "ArtcId",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BrandId",
                table: "Articles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArtcId",
                table: "Articles",
                column: "ArtcId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_BrandId",
                table: "Articles",
                column: "BrandId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_ClassificationArt_ArtcId",
                table: "Articles",
                column: "ArtcId",
                principalTable: "ClassificationArt",
                principalColumn: "ArtcId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Brand_BrandId",
                table: "Articles",
                column: "BrandId",
                principalTable: "Brand",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_ClassificationArt_ArtcId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Brand_BrandId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_ArtcId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_BrandId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ArtcId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "BrandId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "ArticlesId",
                table: "ClassificationArt",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ArticlesId",
                table: "Brand",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClassificationArt_ArticlesId",
                table: "ClassificationArt",
                column: "ArticlesId");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_ArticlesId",
                table: "Brand",
                column: "ArticlesId");

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
    }
}
