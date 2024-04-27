using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class expandedActionAndActionCountTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SiteRGWTotal",
                table: "SiteActionCounts",
                newName: "SiteGlobalWarmingTotal");

            migrationBuilder.AddColumn<int>(
                name: "SiteBuyRecycled",
                table: "SiteActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteFamilySizes",
                table: "SiteActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteHabitatRestoration",
                table: "SiteActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteHerbsAndPesticides",
                table: "SiteActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SitePlantNative",
                table: "SiteActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteSlowDown",
                table: "SiteActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SiteWildlifeRefuge",
                table: "SiteActionCounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuyRecycled",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FamilySizes",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HabitatRestoration",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HerbsAndPesticides",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlantNative",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SlowDown",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WildlifeRefuge",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteBuyRecycled",
                table: "SiteActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteFamilySizes",
                table: "SiteActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteHabitatRestoration",
                table: "SiteActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteHerbsAndPesticides",
                table: "SiteActionCounts");

            migrationBuilder.DropColumn(
                name: "SitePlantNative",
                table: "SiteActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteSlowDown",
                table: "SiteActionCounts");

            migrationBuilder.DropColumn(
                name: "SiteWildlifeRefuge",
                table: "SiteActionCounts");

            migrationBuilder.DropColumn(
                name: "BuyRecycled",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "FamilySizes",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "HabitatRestoration",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "HerbsAndPesticides",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "PlantNative",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "SlowDown",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "WildlifeRefuge",
                table: "RGWActions");

            migrationBuilder.RenameColumn(
                name: "SiteGlobalWarmingTotal",
                table: "SiteActionCounts",
                newName: "SiteRGWTotal");
        }
    }
}
