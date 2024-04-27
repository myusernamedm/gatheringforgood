using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class videoUrlFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Video1",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video10",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video11",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video12",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video13",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video14",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video15",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video2",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video3",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video4",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video5",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video6",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video7",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video8",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Video9",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Video1",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video10",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video11",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video12",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video13",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video14",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video15",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video2",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video3",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video4",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video5",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video6",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video7",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video8",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Video9",
                table: "ArticleDetails");
        }
    }
}
