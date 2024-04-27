using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class addedLinkColumnsToArticlesList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HREFLink",
                table: "ArticlesList",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RazorLink",
                table: "ArticlesList",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HREFLink",
                table: "ArticlesList");

            migrationBuilder.DropColumn(
                name: "RazorLink",
                table: "ArticlesList");
        }
    }
}
