using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class ClicksColumnsToSiteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SiteDeforestationClicks",
                table: "SiteEnvironmentalActionCounts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SiteExtinctionClicks",
                table: "SiteEnvironmentalActionCounts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SiteGlobalWarmingClicks",
                table: "SiteEnvironmentalActionCounts",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteDeforestationClicks",
                table: "SiteEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteExtinctionClicks",
                table: "SiteEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteGlobalWarmingClicks",
                table: "SiteEnvironmentalActionCounts");
        }
    }
}
