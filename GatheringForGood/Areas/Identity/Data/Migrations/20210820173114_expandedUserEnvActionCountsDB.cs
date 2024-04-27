using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class expandedUserEnvActionCountsDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "UserBuyLocalCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserBuyRecycledCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserCarpoolCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserCompostBinCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserCycleCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserDonateCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserDriveElectricCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserEatOrganicCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserFamilySizesCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserFluorescentBulbsCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserFlyLessCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserGoPaperlessCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserGoVeganCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserGoVegetarianCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserGreenRecoveryCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserGrowVegCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserHabitatRestorationCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserHerbsAndPesticidesCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserHomeInsulationCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserLiveCarFreeCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserMinimisePlasticCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserPlantNativeCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserPlantTreesCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserPublicTransportCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserRecyclingBinCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserReduceMeatCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserRenewableEnergyCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserShorterShowersCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserSignPetitionCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserSlowDownCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserSocialMediaCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserStandUpCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserTurnOffLightsCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserWildlifeRefugeCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UserZeroDeforestationCO2Total",
                table: "UserEnvironmentalActionCounts",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserBuyLocalCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserBuyRecycledCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserCarpoolCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserCompostBinCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserCycleCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserDonateCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserDriveElectricCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserEatOrganicCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserFamilySizesCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserFluorescentBulbsCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserFlyLessCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserGoPaperlessCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserGoVeganCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserGoVegetarianCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserGreenRecoveryCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserGrowVegCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserHabitatRestorationCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserHerbsAndPesticidesCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserHomeInsulationCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserLiveCarFreeCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserMinimisePlasticCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserPlantNativeCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserPlantTreesCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserPublicTransportCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserRecyclingBinCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserReduceMeatCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserRenewableEnergyCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserShorterShowersCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserSignPetitionCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserSlowDownCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserSocialMediaCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserStandUpCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserTurnOffLightsCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserWildlifeRefugeCO2Total",
                table: "UserEnvironmentalActionCounts");

            migrationBuilder.DropColumn(
                name: "UserZeroDeforestationCO2Total",
                table: "UserEnvironmentalActionCounts");
        }
    }
}
