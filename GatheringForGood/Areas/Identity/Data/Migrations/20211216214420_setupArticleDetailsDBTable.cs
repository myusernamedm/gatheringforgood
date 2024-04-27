using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class setupArticleDetailsDBTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArticleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleVideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Snippet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image6 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image7 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image8 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image9 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image10 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image12 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image13 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image14 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Para15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image15 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UniqueReference = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleDetails");
        }
    }
}
