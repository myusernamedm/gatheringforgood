using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.Identity.Data
{
    public class UserContact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Number { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime")]
        public DateTime FeedbackDate { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Subject { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 5)]
        public string Thoughts { get; set; }

        [Required]
        public bool TandC { get; set; }
    }
}
