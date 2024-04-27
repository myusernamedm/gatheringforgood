using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RGWActions",
                table: "RGWActions");

            migrationBuilder.RenameTable(
                name: "RGWActions",
                newName: "UserEnvironmentalAction");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserEnvironmentalAction",
                table: "UserEnvironmentalAction",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserEnvironmentalAction",
                table: "UserEnvironmentalAction");

            migrationBuilder.RenameTable(
                name: "UserEnvironmentalAction",
                newName: "RGWActions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RGWActions",
                table: "RGWActions",
                column: "Id");
        }
    }
}
