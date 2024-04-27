using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AreasYouCanHelp",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FeatureUpdates",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NewBlogPosts",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ProductNews",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreasYouCanHelp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FeatureUpdates",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NewBlogPosts",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProductNews",
                table: "AspNetUsers");
        }
    }
}
