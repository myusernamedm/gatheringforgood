using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class changetodouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "UserZeroDeforestationCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserWildlifeRefugeCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserTurnOffLightsCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserStandUpCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserSocialMediaCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserSlowDownCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserSignPetitionCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserShorterShowersCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserRenewableEnergyCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserReduceMeatCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserRecyclingBinCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserPublicTransportCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserPlantTreesCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserPlantNativeCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserMinimisePlasticCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserLiveCarFreeCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserHomeInsulationCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserHerbsAndPesticidesCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserHabitatRestorationCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserGrowVegCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserGreenRecoveryCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserGoVegetarianCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserGoVeganCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserGoPaperlessCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserFlyLessCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserFluorescentBulbsCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserFamilySizesCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserEatOrganicCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserDriveElectricCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserDonateCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserCycleCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserCompostBinCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserCarpoolCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserBuyRecycledCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "UserBuyLocalCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "UserZeroDeforestationCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserWildlifeRefugeCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserTurnOffLightsCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserStandUpCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserSocialMediaCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserSlowDownCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserSignPetitionCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserShorterShowersCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserRenewableEnergyCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserReduceMeatCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserRecyclingBinCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserPublicTransportCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserPlantTreesCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserPlantNativeCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserMinimisePlasticCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserLiveCarFreeCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserHomeInsulationCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserHerbsAndPesticidesCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserHabitatRestorationCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserGrowVegCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserGreenRecoveryCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserGoVegetarianCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserGoVeganCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserGoPaperlessCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserFlyLessCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserFluorescentBulbsCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserFamilySizesCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserEatOrganicCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserDriveElectricCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserDonateCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserCycleCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserCompostBinCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserCarpoolCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserBuyRecycledCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<float>(
                name: "UserBuyLocalCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
