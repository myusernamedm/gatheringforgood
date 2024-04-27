using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class replaceblogwitharticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewBlogPosts",
                table: "AspNetUsers",
                newName: "NewArticlePosts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NewArticlePosts",
                table: "AspNetUsers",
                newName: "NewBlogPosts");
        }
    }
}
