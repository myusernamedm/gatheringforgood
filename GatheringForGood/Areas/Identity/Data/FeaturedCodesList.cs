using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GatheringForGood.Areas.Identity.Data
{
    public class FeaturedCodesList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Number { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime")]
        public DateTime Expires { get; set; }

        [Required]
        public int UseCount { get; set; }
    }
}
