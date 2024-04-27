using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class subheadingsTwoToFifteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Para10Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para11Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para12Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para13Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para14Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para15Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para2Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para3Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para4Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para5Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para6Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para7Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para8Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Para9Subheading",
                table: "ArticleDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Para10Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para11Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para12Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para13Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para14Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para15Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para2Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para3Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para4Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para5Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para6Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para7Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para8Subheading",
                table: "ArticleDetails");

            migrationBuilder.DropColumn(
                name: "Para9Subheading",
                table: "ArticleDetails");
        }
    }
}
