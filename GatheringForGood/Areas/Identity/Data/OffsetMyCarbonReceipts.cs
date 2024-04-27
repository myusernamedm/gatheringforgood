using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GatheringForGood.Areas.Identity.Data
{
    public class OffsetMyCarbonReceipts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Number { get; set; }

        public string UserId { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Column(TypeName = "datetime")]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public int ModeOfTransportType { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PercentagePublic { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PercentageDriving1 { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal PercentageDriving2 { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal CO2Transport { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal CO2Flight { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal CO2Food { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal CO2ShoppingLeisure { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal CO2Accomodation { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal CO2PublicServices { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal CO2Total { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal PriceTransport { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal PriceFlight { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal PriceFood { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal PriceShoppingLeisure { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal PriceAccomodation { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal PricePublicServices { get; set; }
        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal PriceTotal { get; set; }
    }
}
