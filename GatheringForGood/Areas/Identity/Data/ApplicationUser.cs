using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Data
{
    
    public class ApplicationUser: IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [PersonalData]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime")]
        public DateTime SignedUp { get; set; }

        [PersonalData]
        [Required]
        public bool TandC { get; set; }
        [PersonalData]
        public bool MarketingComms { get; set; }
        [PersonalData]
        public bool FeatureUpdates { get; set; }
        [PersonalData]
        public bool ProductNews { get; set; }
        [PersonalData]
        public bool NewArticlePosts { get; set; }
        [PersonalData]
        public bool AreasYouCanHelp { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(200)")]
        public string CompanyName { get; set; }

        [PersonalData]
        public string Skill { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string AreaOfInterest { get; set; }

        [PersonalData]
        public int Age { get; set; }

        [PersonalData]
        public string Country { get; set; }

        [PersonalData]
        public string Region { get; set; }

        public static implicit operator ApplicationUser(HttpContext v)
        {
            throw new NotImplementedException();
        }
        public int TreesPurchased { get; set; }
    }
    
}
