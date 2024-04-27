using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class deleteduserbadgestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBadges");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserBadges",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingBackBetter = table.Column<int>(type: "int", nullable: false),
                    CommunicatingForDifference = table.Column<int>(type: "int", nullable: false),
                    ContributorForGood = table.Column<int>(type: "int", nullable: false),
                    DefeatAnimalExtinction = table.Column<int>(type: "int", nullable: false),
                    DefeatDeforestation = table.Column<int>(type: "int", nullable: false),
                    DefeatGlobalWarming = table.Column<int>(type: "int", nullable: false),
                    FeedbackHero = table.Column<int>(type: "int", nullable: false),
                    FirstStep = table.Column<int>(type: "int", nullable: false),
                    GathererForGood = table.Column<int>(type: "int", nullable: false),
                    Helpful = table.Column<bool>(type: "bit", nullable: false),
                    KeyDriverOfChange = table.Column<int>(type: "int", nullable: false),
                    Leader = table.Column<bool>(type: "bit", nullable: false),
                    LearningForGood = table.Column<int>(type: "int", nullable: false),
                    MakingADifference = table.Column<int>(type: "int", nullable: false),
                    PassionateStartCountDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlanetCare = table.Column<bool>(type: "bit", nullable: false),
                    PlanetCareStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Thankyou = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visionary = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBadges", x => x.Number);
                });
        }
    }
}
