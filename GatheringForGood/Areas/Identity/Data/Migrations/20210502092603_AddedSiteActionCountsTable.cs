using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class AddedSiteActionCountsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Total",
                table: "RGWActions",
                newName: "UserTotal");

            migrationBuilder.CreateTable(
                name: "SiteActionCounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SiteTotal = table.Column<int>(type: "int", nullable: false),
                    RGWTotal = table.Column<int>(type: "int", nullable: false),
                    DeforestationTotal = table.Column<int>(type: "int", nullable: false),
                    ExtinctionTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteActionCounts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteActionCounts");

            migrationBuilder.RenameColumn(
                name: "UserTotal",
                table: "RGWActions",
                newName: "Total");
        }
    }
}
