﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace GatheringForGood.Data.Migrations
{
    public partial class treesPurchasedUserColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TreesPurchased",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TreesPurchased",
                table: "AspNetUsers");
        }
    }
}
