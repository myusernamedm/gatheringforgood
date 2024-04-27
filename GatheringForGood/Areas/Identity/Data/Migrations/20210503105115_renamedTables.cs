using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class renamedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteActionCounts");

            migrationBuilder.DropTable(
                name: "UserEnvironmentalAction");

            migrationBuilder.CreateTable(
                name: "SiteEnvironmentalActionCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteTotal = table.Column<long>(type: "bigint", nullable: false),
                    SiteGlobalWarmingTotal = table.Column<long>(type: "bigint", nullable: false),
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
                    SiteSignPetition = table.Column<int>(type: "int", nullable: false),
                    SiteFamilySizes = table.Column<int>(type: "int", nullable: false),
                    SiteHabitatRestoration = table.Column<int>(type: "int", nullable: false),
                    SiteWildlifeRefuge = table.Column<int>(type: "int", nullable: false),
                    SiteHerbsAndPesticides = table.Column<int>(type: "int", nullable: false),
                    SiteSlowDown = table.Column<int>(type: "int", nullable: false),
                    SitePlantNative = table.Column<int>(type: "int", nullable: false),
                    SiteBuyRecycled = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteEnvironmentalActionCounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEnvironmentalActionCounts",
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
                    SignPetition = table.Column<int>(type: "int", nullable: false),
                    FamilySizes = table.Column<int>(type: "int", nullable: false),
                    HabitatRestoration = table.Column<int>(type: "int", nullable: false),
                    WildlifeRefuge = table.Column<int>(type: "int", nullable: false),
                    HerbsAndPesticides = table.Column<int>(type: "int", nullable: false),
                    SlowDown = table.Column<int>(type: "int", nullable: false),
                    PlantNative = table.Column<int>(type: "int", nullable: false),
                    BuyRecycled = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEnvironmentalActionCounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteEnvironmentalActionCounts");

            migrationBuilder.DropTable(
                name: "UserEnvironmentalActionCounts");

            migrationBuilder.CreateTable(
                name: "SiteActionCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteBuyLocal = table.Column<int>(type: "int", nullable: false),
                    SiteBuyRecycled = table.Column<int>(type: "int", nullable: false),
                    SiteCarpool = table.Column<int>(type: "int", nullable: false),
                    SiteCompostBin = table.Column<int>(type: "int", nullable: false),
                    SiteCycle = table.Column<int>(type: "int", nullable: false),
                    SiteDeforestationTotal = table.Column<long>(type: "bigint", nullable: false),
                    SiteDriveElectric = table.Column<int>(type: "int", nullable: false),
                    SiteEatOrganic = table.Column<int>(type: "int", nullable: false),
                    SiteExtinctionTotal = table.Column<long>(type: "bigint", nullable: false),
                    SiteFamilySizes = table.Column<int>(type: "int", nullable: false),
                    SiteFluorescentBulbs = table.Column<int>(type: "int", nullable: false),
                    SiteFlyLess = table.Column<int>(type: "int", nullable: false),
                    SiteGlobalWarmingTotal = table.Column<long>(type: "bigint", nullable: false),
                    SiteGoVegan = table.Column<int>(type: "int", nullable: false),
                    SiteGoVegetarian = table.Column<int>(type: "int", nullable: false),
                    SiteGreenRecovery = table.Column<int>(type: "int", nullable: false),
                    SiteGrowVeg = table.Column<int>(type: "int", nullable: false),
                    SiteHabitatRestoration = table.Column<int>(type: "int", nullable: false),
                    SiteHerbsAndPesticides = table.Column<int>(type: "int", nullable: false),
                    SiteHomeInsulation = table.Column<int>(type: "int", nullable: false),
                    SiteLiveCarFree = table.Column<int>(type: "int", nullable: false),
                    SiteMinimisePlastic = table.Column<int>(type: "int", nullable: false),
                    SitePlantNative = table.Column<int>(type: "int", nullable: false),
                    SitePlantTrees = table.Column<int>(type: "int", nullable: false),
                    SitePublicTransport = table.Column<int>(type: "int", nullable: false),
                    SiteRecyclingBin = table.Column<int>(type: "int", nullable: false),
                    SiteReduceMeat = table.Column<int>(type: "int", nullable: false),
                    SiteRenewableEnergy = table.Column<int>(type: "int", nullable: false),
                    SiteShorterShowers = table.Column<int>(type: "int", nullable: false),
                    SiteSignPetition = table.Column<int>(type: "int", nullable: false),
                    SiteSlowDown = table.Column<int>(type: "int", nullable: false),
                    SiteStandUp = table.Column<int>(type: "int", nullable: false),
                    SiteTotal = table.Column<long>(type: "bigint", nullable: false),
                    SiteTurnOffLights = table.Column<int>(type: "int", nullable: false),
                    SiteWildlifeRefuge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteActionCounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEnvironmentalAction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BuyLocal = table.Column<int>(type: "int", nullable: false),
                    BuyRecycled = table.Column<int>(type: "int", nullable: false),
                    Carpool = table.Column<int>(type: "int", nullable: false),
                    CompostBin = table.Column<int>(type: "int", nullable: false),
                    Cycle = table.Column<int>(type: "int", nullable: false),
                    DriveElectric = table.Column<int>(type: "int", nullable: false),
                    EatOrganic = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilySizes = table.Column<int>(type: "int", nullable: false),
                    FluorescentBulbs = table.Column<int>(type: "int", nullable: false),
                    FlyLess = table.Column<int>(type: "int", nullable: false),
                    GoVegan = table.Column<int>(type: "int", nullable: false),
                    GoVegetarian = table.Column<int>(type: "int", nullable: false),
                    GreenRecovery = table.Column<int>(type: "int", nullable: false),
                    GrowVeg = table.Column<int>(type: "int", nullable: false),
                    HabitatRestoration = table.Column<int>(type: "int", nullable: false),
                    HerbsAndPesticides = table.Column<int>(type: "int", nullable: false),
                    HomeInsulation = table.Column<int>(type: "int", nullable: false),
                    LiveCarFree = table.Column<int>(type: "int", nullable: false),
                    MinimisePlastic = table.Column<int>(type: "int", nullable: false),
                    PlantNative = table.Column<int>(type: "int", nullable: false),
                    PlantTrees = table.Column<int>(type: "int", nullable: false),
                    PublicTransport = table.Column<int>(type: "int", nullable: false),
                    RecyclingBin = table.Column<int>(type: "int", nullable: false),
                    ReduceMeat = table.Column<int>(type: "int", nullable: false),
                    RenewableEnergy = table.Column<int>(type: "int", nullable: false),
                    ShorterShowers = table.Column<int>(type: "int", nullable: false),
                    SignPetition = table.Column<int>(type: "int", nullable: false),
                    SlowDown = table.Column<int>(type: "int", nullable: false),
                    StandUp = table.Column<int>(type: "int", nullable: false),
                    TurnOffLights = table.Column<int>(type: "int", nullable: false),
                    UserTotal = table.Column<int>(type: "int", nullable: false),
                    WildlifeRefuge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEnvironmentalAction", x => x.Id);
                });
        }
    }
}
