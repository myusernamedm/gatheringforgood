using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class newTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RGWActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTotal = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "SiteActionCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteTotal = table.Column<long>(type: "bigint", nullable: false),
                    SiteRGWTotal = table.Column<long>(type: "bigint", nullable: false),
                    SiteDeforestationTotal = table.Column<long>(type: "bigint", nullable: false),
                    SiteExtinctionTotal = table.Column<long>(type: "bigint", nullable: false),
                    SiteReduceMeat = table.Column<int>(type: "int", nullable: false),
                    SitePlantTrees = table.Column<int>(type: "int", nullable: false),
                    SiteEatOrganic = table.Column<int>(type: "int", nullable: false),
                    SiteGoVegetarian = table.Column<int>(type: "int", nullable: false),
                    SiteGoVegan = table.Column<int>(type: "int", nullable: false),
                    SiteLiveCarFree = table.Column<int>(type: "int", nullable: false),
                    SiteGreenRecovery = table.Column<int>(type: "int", nullable: false),
                    SiteMinimisePlastic = table.Column<int>(type: "int", nullable: false),
                    SiteBuyLocal = table.Column<int>(type: "int", nullable: false),
                    SiteCycle = table.Column<int>(type: "int", nullable: false),
                    SiteDriveElectric = table.Column<int>(type: "int", nullable: false),
                    SiteGrowVeg = table.Column<int>(type: "int", nullable: false),
                    SiteRenewableEnergy = table.Column<int>(type: "int", nullable: false),
                    SitePublicTransport = table.Column<int>(type: "int", nullable: false),
                    SiteCarpool = table.Column<int>(type: "int", nullable: false),
                    SiteFlyLess = table.Column<int>(type: "int", nullable: false),
                    SiteStandUp = table.Column<int>(type: "int", nullable: false),
                    SiteRecyclingBin = table.Column<int>(type: "int", nullable: false),
                    SiteCompostBin = table.Column<int>(type: "int", nullable: false),
                    SiteHomeInsulation = table.Column<int>(type: "int", nullable: false),
                    SiteShorterShowers = table.Column<int>(type: "int", nullable: false),
                    SiteFluorescentBulbs = table.Column<int>(type: "int", nullable: false),
                    SiteTurnOffLights = table.Column<int>(type: "int", nullable: false),
                    SiteSignPetition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteActionCounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RGWActions");

            migrationBuilder.DropTable(
                name: "SiteActionCounts");
        }
    }
}
