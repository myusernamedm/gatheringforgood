using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class RGWActionsList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuyLocal",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Carpool",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompostBin",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cycle",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DriveElectric",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EatOrganic",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FluorescentBulbs",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlyLess",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoVegan",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoVegetarian",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GreenRecovery",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GrowVeg",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomeInsulation",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LiveCarFree",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinimisePlastic",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlantTrees",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PublicTransport",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecyclingBin",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RenewableEnergy",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShorterShowers",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SignPetition",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StandUp",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TurnOffLights",
                table: "RGWActions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyLocal",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "Carpool",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "CompostBin",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "Cycle",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "DriveElectric",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "EatOrganic",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "FluorescentBulbs",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "FlyLess",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "GoVegan",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "GoVegetarian",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "GreenRecovery",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "GrowVeg",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "HomeInsulation",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "LiveCarFree",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "MinimisePlastic",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "PlantTrees",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "PublicTransport",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "RecyclingBin",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "RenewableEnergy",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "ShorterShowers",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "SignPetition",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "StandUp",
                table: "RGWActions");

            migrationBuilder.DropColumn(
                name: "TurnOffLights",
                table: "RGWActions");
        }
    }
}
