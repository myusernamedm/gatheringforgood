using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class offsetmycarbonreceiptstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OffsetMyCarbonReceipts",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchaseDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModeOfTransportType = table.Column<int>(type: "int", nullable: false),
                    PercentagePublic = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PercentageDriving1 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PercentageDriving2 = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CO2Transport = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CO2Flight = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CO2Food = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CO2ShoppingLeisure = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CO2Accomodation = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CO2PublicServices = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CO2Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    PriceTransport = table.Column<decimal>(type: "smallmoney", nullable: false),
                    PriceFlight = table.Column<decimal>(type: "smallmoney", nullable: false),
                    PriceFood = table.Column<decimal>(type: "smallmoney", nullable: false),
                    PriceShoppingLeisure = table.Column<decimal>(type: "smallmoney", nullable: false),
                    PriceAccomodation = table.Column<decimal>(type: "smallmoney", nullable: false),
                    PricePublicServices = table.Column<decimal>(type: "smallmoney", nullable: false),
                    PriceTotal = table.Column<decimal>(type: "smallmoney", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OffsetMyCarbonReceipts", x => x.Number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OffsetMyCarbonReceipts");
        }
    }
}
