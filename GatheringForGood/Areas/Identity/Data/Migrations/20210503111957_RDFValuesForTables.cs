using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class RDFValuesForTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Donate",
                table: "UserEnvironmentalActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoPaperless",
                table: "UserEnvironmentalActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SocialMedia",
                table: "UserEnvironmentalActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ZeroDeforestation",
                table: "UserEnvironmentalActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteDonate",
                table: "SiteEnvironmentalActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteGoPaperless",
                table: "SiteEnvironmentalActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteSocialMedia",
                table: "SiteEnvironmentalActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteZeroDeforestation",
                table: "SiteEnvironmentalActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Donate",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "GoPaperless",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "SocialMedia",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "ZeroDeforestation",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteDonate",
                table: "SiteEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteGoPaperless",
                table: "SiteEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteSocialMedia",
                table: "SiteEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteZeroDeforestation",
                table: "SiteEnvironmentalActionCounts");
        }
    }
}
