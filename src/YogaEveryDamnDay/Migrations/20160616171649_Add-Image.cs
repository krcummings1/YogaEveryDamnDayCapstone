using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YogaEveryDamnDay.Migrations
{
    public partial class AddImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base64Image",
                table: "Pose");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Pose",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Pose");

            migrationBuilder.AddColumn<byte[]>(
                name: "Base64Image",
                table: "Pose",
                nullable: true);
        }
    }
}
