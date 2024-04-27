using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class LikesColumnsArticlesListAndDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dislikes",
                table: "ArticlesList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "ArticlesList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Questionable",
                table: "ArticlesList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Shocked",
                table: "ArticlesList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Support",
                table: "ArticlesList",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dislikes",
                table: "ArticleDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "ArticleDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Questionable",
                table: "ArticleDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Shocked",
                table: "ArticleDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Support",
                table: "ArticleDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dislikes",
                table: "ArticlesList");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "ArticlesList");

            migrationBuilder.DropColumn(
                name: "Questionable",
                table: "ArticlesList");

            migrationBuilder.DropColumn(
                name: "Shocked",
                table: "ArticlesList");

            migrationBuilder.DropColumn(
                name: "Support",
                table: "ArticlesList");

            migrationBuilder.DropColumn(
                name: "Dislikes",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Questionable",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Shocked",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Support",
                table: "ArticleDetails");
        }
    }
}
