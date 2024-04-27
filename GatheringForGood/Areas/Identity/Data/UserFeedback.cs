using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GatheringForGood.Areas.Identity.Data
{
    public class UserFeedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Number { get; set; }
        public string UserId { get; set; }
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime")]
        public DateTime FeedbackDate { get; set; }
        public string Feedback { get; set; }
        public string DataSource { get; set; }
    }
}
