using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.Identity.Data
{
    public class UserBadges
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Number { get; set; }
        public string UserId { get; set; }
        public int FirstStep { get; set; }
        public int GathererForGood { get; set; }
        public int BuildingBackBetter { get; set; }
        public int KeyDriverOfChange { get; set; }
        public int DefeatGlobalWarming { get; set; }
        public int DefeatAnimalExtinction { get; set; }
        public int DefeatDeforestation { get; set; }
        public bool PlanetCare { get; set; }

        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime? PlanetCareStartDate { get; set; }
        public int CommunicatingForDifference { get; set; }
        public int ContributorForGood { get; set; }

        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime? PassionateStartCountDate { get; set; }
        public bool Helpful { get; set; }
        public bool Leader { get; set; }
        public bool Visionary { get; set; }
        public bool Thankyou { get; set; }
        public int LearningForGood { get; set; }
        public int MakingADifference { get; set; }
        public int FeedbackHero { get; set; }
    }
}
