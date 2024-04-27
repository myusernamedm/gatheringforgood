using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class RGWActionDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RGWActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    ReduceMeat = table.Column<int>(type: "int", nullable: false),
                    PlantTrees = table.Column<int>(type: "int", nullable: false),
                    EatOrganic = table.Column<int>(type: "int", nullable: false),
                    GoVegetarian = table.Column<int>(type: "int", nullable: false),
                    GoVegan = table.Column<int>(type: "int", nullable: false),
                    LiveCarFree = table.Column<int>(type: "int", nullable: false),
                    GreenRecovery = table.Column<int>(type: "int", nullable: false),
                    MinimisePlastic = table.Column<int>(type: "int", nullable: false),
                    BuyLocal = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    DriveElectric = table.Column<int>(type: "int", nullable: false),
                    GrowVeg = table.Column<int>(type: "int", nullable: false),
                    RenewableEnergy = table.Column<int>(type: "int", nullable: false),
                    PublicTransport = table.Column<int>(type: "int", nullable: false),
                    Carpool = table.Column<int>(type: "int", nullable: false),
                    FlyLess = table.Column<int>(type: "int", nullable: false),
                    StandUp = table.Column<int>(type: "int", nullable: false),
                    RecyclingBin = table.Column<int>(type: "int", nullable: false),
                    CompostBin = table.Column<int>(type: "int", nullable: false),
                    HomeInsulation = table.Column<int>(type: "int", nullable: false),
                    ShorterShowers = table.Column<int>(type: "int", nullable: false),
                    FluorescentBulbs = table.Column<int>(type: "int", nullable: false),
                    TurnOffLights = table.Column<int>(type: "int", nullable: false),
                    SignPetition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RGWActions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RGWActions");
        }
    }
}
