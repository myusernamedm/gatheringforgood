using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class recreateduserbadgesbyrenamingnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBadgesNew");

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
                    PlanetCareStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CommunicatingForDifference = table.Column<int>(type: "int", nullable: false),
                    ContributorForGood = table.Column<int>(type: "int", nullable: false),
                    PassionateStartCountDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Helpful = table.Column<bool>(type: "bit", nullable: false),
                    Leader = table.Column<bool>(type: "bit", nullable: false),
                    Visionary = table.Column<bool>(type: "bit", nullable: false),
                    Thankyou = table.Column<bool>(type: "bit", nullable: false),
                    LearningForGood = table.Column<int>(type: "int", nullable: false),
                    MakingADifference = table.Column<int>(type: "int", nullable: false),
                    FeedbackHero = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "UserBadgesNew",
                columns: table => new
                {
                    NumberNew = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBadgesNew", x => x.NumberNew);
                });
        }
    }
}
