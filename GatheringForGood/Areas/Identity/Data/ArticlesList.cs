using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.Identity.Data
{
    public class ArticlesList
    {
        [Key]
        public int ArticleReference { get; set; }
        [Required]
        public string TitleImageUrl { get; set; }
        [Required]
        public string TitleVideoUrl { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Snippet { get; set; }
        [Required]
        public string RazorLink { get; set; }
        [Required]
        public string HREFLink { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime? PostedDateTime { get; set; }
        [Required]
        public bool WeeklyNewsList { get; set; }
        [Required]
        public string UniqueReference { get; set; }
        [Required]
        public string AuthorFirstName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }
        [Required]
        public bool ShowArticle { get; set; }
        [Required]
        public bool Featured { get; set; }
        [Required]
        public bool TreePlanted { get; set; }
        [Required]
        public int ArticleViews { get; set; }
        [Required]
        public int Likes { get; set; }
        [Required]
        public int Dislikes { get; set; }
        [Required]
        public int Shocked { get; set; }
        [Required]
        public int Support { get; set; }
        [Required]
        public int Questionable { get; set; }
    }
}
