using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class userbadgesdbtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserBadges",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstStep = table.Column<int>(type: "int", nullable: false),
                    GathererForGood = table.Column<int>(type: "int", nullable: false),
                    BuildingBackBetter = table.Column<int>(type: "int", nullable: false),
                    KeyDriverOfChange = table.Column<int>(type: "int", nullable: false),
                    DefeatGlobalWarming = table.Column<int>(type: "int", nullable: false),
                    DefeatAnimalExtinction = table.Column<int>(type: "int", nullable: false),
                    DefeatDeforestation = table.Column<int>(type: "int", nullable: false),
                    PlanetCare = table.Column<bool>(type: "bit", nullable: false),
                    PlanetCareStartDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CommunicatingForDifference = table.Column<int>(type: "int", nullable: false),
                    ContributorForGood = table.Column<int>(type: "int", nullable: false),
                    PassionateStartCountDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Helpful = table.Column<bool>(type: "bit", nullable: false),
                    Leader = table.Column<bool>(type: "bit", nullable: false),
                    Visionary = table.Column<bool>(type: "bit", nullable: false),
                    Thankyou = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBadges", x => x.Number);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBadges");
        }
    }
}
