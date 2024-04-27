using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.Identity
{
    public class SiteEnvironmentalActionCounts
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public long SiteTotal { get; set; }
        public double AllUserCo2Total { get; set; }
        public long SiteGlobalWarmingTotal { get; set; }
        public long SiteDeforestationTotal { get; set; }
        public long SiteExtinctionTotal { get; set; }
        public long SiteGlobalWarmingClicks { get; set; }
        public long SiteDeforestationClicks { get; set; }
        public long SiteExtinctionClicks { get; set; }
        public int SiteReduceMeat { get; set; }
        public int SitePlantTrees { get; set; }
        public int SiteEatOrganic { get; set; }
        public int SiteGoVegetarian { get; set; }
        public int SiteGoVegan { get; set; }
        public int SiteLiveCarFree { get; set; }
        public int SiteGreenRecovery { get; set; }
        public int SiteMinimisePlastic { get; set; }
        public int SiteBuyLocal { get; set; }
        public int SiteCycle { get; set; }
        public int SiteDriveElectric { get; set; }
        public int SiteGrowVeg { get; set; }
        public int SiteRenewableEnergy { get; set; }
        public int SitePublicTransport { get; set; }
        public int SiteCarpool { get; set; }
        public int SiteFlyLess { get; set; }
        public int SiteStandUp { get; set; }
        public int SiteRecyclingBin { get; set; }
        public int SiteCompostBin { get; set; }
        public int SiteHomeInsulation { get; set; }
        public int SiteShorterShowers { get; set; }
        public int SiteFluorescentBulbs { get; set; }
        public int SiteTurnOffLights { get; set; }
        public int SiteSignPetition { get; set; }
        public int SiteFamilySizes { get; set; }
        public int SiteHabitatRestoration { get; set; }
        public int SiteWildlifeRefuge { get; set; }
        public int SiteHerbsAndPesticides { get; set; }
        public int SiteSlowDown { get; set; }
        public int SitePlantNative { get; set; }
        public int SiteBuyRecycled { get; set; }
        public int SiteZeroDeforestation { get; set; }
        public int SiteGoPaperless { get; set; }
        public int SiteDonate { get; set; }
        public int SiteSocialMedia { get; set; }
    }
}
