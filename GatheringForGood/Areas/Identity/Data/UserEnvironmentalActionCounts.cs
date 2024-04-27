using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.Identity
{
    public class UserEnvironmentalActionCounts
    {
        [Required]
        [Key]
        public string Id { get; set; }
        public int UserTotal { get; set; }
        public double UserCO2Total { get; set; }
        public int ReduceMeat { get; set; }
        public double UserReduceMeatCO2Total { get; set; }
        public int PlantTrees { get; set; }
        public double UserPlantTreesCO2Total { get; set; }
        public int EatOrganic { get; set; }
        public double UserEatOrganicCO2Total { get; set; }
        public int GoVegetarian { get; set; }
        public double UserGoVegetarianCO2Total { get; set; }
        public int GoVegan { get; set; }
        public double UserGoVeganCO2Total { get; set; }
        public int LiveCarFree { get; set; }
        public double UserLiveCarFreeCO2Total { get; set; }
        public int GreenRecovery { get; set; }
        public double UserGreenRecoveryCO2Total { get; set; }
        public int MinimisePlastic { get; set; }
        public double UserMinimisePlasticCO2Total { get; set; }
        public int BuyLocal { get; set; }
        public double UserBuyLocalCO2Total { get; set; }
        public int Cycle { get; set; }
        public double UserCycleCO2Total { get; set; }
        public int DriveElectric { get; set; }
        public double UserDriveElectricCO2Total { get; set; }
        public int GrowVeg { get; set; }
        public double UserGrowVegCO2Total { get; set; }
        public int RenewableEnergy { get; set; }
        public double UserRenewableEnergyCO2Total { get; set; }
        public int PublicTransport { get; set; }
        public double UserPublicTransportCO2Total { get; set; }
        public int Carpool { get; set; }
        public double UserCarpoolCO2Total { get; set; }
        public int FlyLess { get; set; }
        public double UserFlyLessCO2Total { get; set; }
        public int StandUp { get; set; }
        public double UserStandUpCO2Total { get; set; }
        public int RecyclingBin { get; set; }
        public double UserRecyclingBinCO2Total { get; set; }
        public int CompostBin { get; set; }
        public double UserCompostBinCO2Total { get; set; }
        public int HomeInsulation { get; set; }
        public double UserHomeInsulationCO2Total { get; set; }
        public int ShorterShowers { get; set; }
        public double UserShorterShowersCO2Total { get; set; }
        public int FluorescentBulbs { get; set; }
        public double UserFluorescentBulbsCO2Total { get; set; }
        public int TurnOffLights { get; set; }
        public double UserTurnOffLightsCO2Total { get; set; }
        public int SignPetition { get; set; }
        public double UserSignPetitionCO2Total { get; set; }
        public int FamilySizes { get; set; }
        public double UserFamilySizesCO2Total { get; set; }
        public int HabitatRestoration { get; set; }
        public double UserHabitatRestorationCO2Total { get; set; }
        public int WildlifeRefuge { get; set; }
        public double UserWildlifeRefugeCO2Total { get; set; }
        public int HerbsAndPesticides { get; set; }
        public double UserHerbsAndPesticidesCO2Total { get; set; }
        public int SlowDown { get; set; }
        public double UserSlowDownCO2Total { get; set; }
        public int PlantNative { get; set; }
        public double UserPlantNativeCO2Total { get; set; }
        public int BuyRecycled { get; set; }
        public double UserBuyRecycledCO2Total { get; set; }
        public int ZeroDeforestation { get; set; }
        public double UserZeroDeforestationCO2Total { get; set; }
        public int GoPaperless { get; set; }
        public double UserGoPaperlessCO2Total { get; set; }
        public int Donate { get; set; }
        public double UserDonateCO2Total { get; set; }
        public int SocialMedia { get; set; }
        public double UserSocialMediaCO2Total { get; set; }
    }
}
