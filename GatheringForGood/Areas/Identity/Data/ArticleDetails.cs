using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.Identity.Data
{
    public class ArticleDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Title { get; set; }
        public string TitleImageUrl { get; set; }
        public string TitleVideoUrl { get; set; }
        [Required]
        public string Snippet { get; set; }
        public string Para1 { get; set; }
        public string Image1 { get; set; }
        public string Video1 { get; set; }
        public string Para2Subheading { get; set; }
        public string Para3Subheading { get; set; }
        public string Para4Subheading { get; set; }
        public string Para5Subheading { get; set; }
        public string Para6Subheading { get; set; }
        public string Para7Subheading { get; set; }
        public string Para8Subheading { get; set; }
        public string Para9Subheading { get; set; }
        public string Para10Subheading { get; set; }
        public string Para11Subheading { get; set; }
        public string Para12Subheading { get; set; }
        public string Para13Subheading { get; set; }
        public string Para14Subheading { get; set; }
        public string Para15Subheading { get; set; }
        public string Para16Subheading { get; set; }
        public string Para17Subheading { get; set; }
        public string Para18Subheading { get; set; }
        public string Para19Subheading { get; set; }
        public string Para20Subheading { get; set; }
        public string Para21Subheading { get; set; }
        public string Para22Subheading { get; set; }
        public string Para23Subheading { get; set; }
        public string Para24Subheading { get; set; }
        public string Para25Subheading { get; set; }
        public string Para26Subheading { get; set; }
        public string Para27Subheading { get; set; }
        public string Para28Subheading { get; set; }
        public string Para29Subheading { get; set; }
        public string Para30Subheading { get; set; }
        public string Para31Subheading { get; set; }
        public string Para32Subheading { get; set; }
        public string Para33Subheading { get; set; }
        public string Para34Subheading { get; set; }
        public string Para35Subheading { get; set; }
        public string Para36Subheading { get; set; }
        public string Para37Subheading { get; set; }
        public string Para38Subheading { get; set; }
        public string Para39Subheading { get; set; }
        public string Para40Subheading { get; set; }
        public string Para41Subheading { get; set; }
        public string Para42Subheading { get; set; }
        public string Para43Subheading { get; set; }
        public string Para44Subheading { get; set; }
        public string Para45Subheading { get; set; }
        public string Para46Subheading { get; set; }
        public string Para47Subheading { get; set; }
        public string Para48Subheading { get; set; }
        public string Para49Subheading { get; set; }
        public string Para50Subheading { get; set; }
        public string Para2 { get; set; }
        public string Image2 { get; set; }
        public string Video2 { get; set; }
        public string Para3 { get; set; }
        public string Image3 { get; set; }
        public string Video3 { get; set; }
        public string Para4 { get; set; }
        public string Image4 { get; set; }
        public string Video4 { get; set; }
        public string Para5 { get; set; }
        public string Image5 { get; set; }
        public string Video5 { get; set; }
        public string Para6 { get; set; }
        public string Image6 { get; set; }
        public string Video6 { get; set; }
        public string Para7 { get; set; }
        public string Image7 { get; set; }
        public string Video7 { get; set; }
        public string Para8 { get; set; }
        public string Image8 { get; set; }
        public string Video8 { get; set; }
        public string Para9 { get; set; }
        public string Image9 { get; set; }
        public string Video9 { get; set; }
        public string Para10 { get; set; }
        public string Image10 { get; set; }
        public string Video10 { get; set; }
        public string Para11 { get; set; }
        public string Image11 { get; set; }
        public string Video11 { get; set; }
        public string Para12 { get; set; }
        public string Image12 { get; set; }
        public string Video12 { get; set; }
        public string Para13 { get; set; }
        public string Image13 { get; set; }
        public string Video13 { get; set; }
        public string Para14 { get; set; }
        public string Image14 { get; set; }
        public string Video14 { get; set; }
        public string Para15 { get; set; }
        public string Image15 { get; set; }
        public string Video15 { get; set; }
        public string Para16 { get; set; }
        public string Image16 { get; set; }
        public string Video16 { get; set; }
        public string Para17 { get; set; }
        public string Image17 { get; set; }
        public string Video17 { get; set; }
        public string Para18 { get; set; }
        public string Image18 { get; set; }
        public string Video18 { get; set; }
        public string Para19 { get; set; }
        public string Image19 { get; set; }
        public string Video19 { get; set; }
        public string Para20 { get; set; }
        public string Image20 { get; set; }
        public string Video20 { get; set; }
        public string Para21 { get; set; }
        public string Image21 { get; set; }
        public string Video21 { get; set; }
        public string Para22 { get; set; }
        public string Image22 { get; set; }
        public string Video22 { get; set; }
        public string Para23 { get; set; }
        public string Image23 { get; set; }
        public string Video23 { get; set; }
        public string Para24 { get; set; }
        public string Image24 { get; set; }
        public string Video24 { get; set; }
        public string Para25 { get; set; }
        public string Image25 { get; set; }
        public string Video25 { get; set; }
        public string Para26 { get; set; }
        public string Image26 { get; set; }
        public string Video26 { get; set; }
        public string Para27 { get; set; }
        public string Image27 { get; set; }
        public string Video27 { get; set; }
        public string Para28 { get; set; }
        public string Image28 { get; set; }
        public string Video28 { get; set; }
        public string Para29 { get; set; }
        public string Image29 { get; set; }
        public string Video29 { get; set; }
        public string Para30 { get; set; }
        public string Image30 { get; set; }
        public string Video30 { get; set; }
        public string Para31 { get; set; }
        public string Image31 { get; set; }
        public string Video31 { get; set; }
        public string Para32 { get; set; }
        public string Image32 { get; set; }
        public string Video32 { get; set; }
        public string Para33 { get; set; }
        public string Image33 { get; set; }
        public string Video33 { get; set; }
        public string Para34 { get; set; }
        public string Image34 { get; set; }
        public string Video34 { get; set; }
        public string Para35 { get; set; }
        public string Image35 { get; set; }
        public string Video35 { get; set; }
        public string Para36 { get; set; }
        public string Image36 { get; set; }
        public string Video36 { get; set; }
        public string Para37 { get; set; }
        public string Image37 { get; set; }
        public string Video37 { get; set; }
        public string Para38 { get; set; }
        public string Image38 { get; set; }
        public string Video38 { get; set; }
        public string Para39 { get; set; }
        public string Image39 { get; set; }
        public string Video39 { get; set; }
        public string Para40 { get; set; }
        public string Image40 { get; set; }
        public string Video40 { get; set; }
        public string Para41 { get; set; }
        public string Image41 { get; set; }
        public string Video41 { get; set; }
        public string Para42 { get; set; }
        public string Image42 { get; set; }
        public string Video42 { get; set; }
        public string Para43 { get; set; }
        public string Image43 { get; set; }
        public string Video43 { get; set; }
        public string Para44 { get; set; }
        public string Image44 { get; set; }
        public string Video44 { get; set; }
        public string Para45 { get; set; }
        public string Image45 { get; set; }
        public string Video45 { get; set; }
        public string Para46 { get; set; }
        public string Image46 { get; set; }
        public string Video46 { get; set; }
        public string Para47 { get; set; }
        public string Image47 { get; set; }
        public string Video47 { get; set; }
        public string Para48 { get; set; }
        public string Image48 { get; set; }
        public string Video48 { get; set; }
        public string Para49 { get; set; }
        public string Image49 { get; set; }
        public string Video49 { get; set; }
        public string Para50 { get; set; }
        public string Image50 { get; set; }
        public string Video50 { get; set; }
        public string ImageTitleCaption { get; set; }
        public string Image2Caption { get; set; }
        public string Image3Caption { get; set; }
        public string Image4Caption { get; set; }
        public string Image5Caption { get; set; }
        public string Image6Caption { get; set; }
        public string Image7Caption { get; set; }
        public string Image8Caption { get; set; }
        public string Image9Caption { get; set; }
        public string Image10Caption { get; set; }
        public string Image11Caption { get; set; }
        public string Image12Caption { get; set; }
        public string Image13Caption { get; set; }
        public string Image14Caption { get; set; }
        public string Image15Caption { get; set; }
        public string Image16Caption { get; set; }
        public string Image17Caption { get; set; }
        public string Image18Caption { get; set; }
        public string Image19Caption { get; set; }
        public string Image20Caption { get; set; }
        public string Image21Caption { get; set; }
        public string Image22Caption { get; set; }
        public string Image23Caption { get; set; }
        public string Image24Caption { get; set; }
        public string Image25Caption { get; set; }
        public string Image26Caption { get; set; }
        public string Image27Caption { get; set; }
        public string Image28Caption { get; set; }
        public string Image29Caption { get; set; }
        public string Image30Caption { get; set; }
        public string Image31Caption { get; set; }
        public string Image32Caption { get; set; }
        public string Image33Caption { get; set; }
        public string Image34Caption { get; set; }
        public string Image35Caption { get; set; }
        public string Image36Caption { get; set; }
        public string Image37Caption { get; set; }
        public string Image38Caption { get; set; }
        public string Image39Caption { get; set; }
        public string Image40Caption { get; set; }
        public string Image41Caption { get; set; }
        public string Image42Caption { get; set; }
        public string Image43Caption { get; set; }
        public string Image44Caption { get; set; }
        public string Image45Caption { get; set; }
        public string Image46Caption { get; set; }
        public string Image47Caption { get; set; }
        public string Image48Caption { get; set; }
        public string Image49Caption { get; set; }
        public string Image50Caption { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime2")]
        public DateTime? PostedDateTime { get; set; }
        [Required]
        public string UniqueReference { get; set; }
        [Required]
        public bool TandC { get; set; }
        [Required]
        public bool Featured { get; set; }
        [Required]
        public bool TreePlanted { get; set; }
        [Required]
        public string AuthorFirstName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }
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
