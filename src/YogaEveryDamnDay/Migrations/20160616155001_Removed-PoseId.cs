using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace YogaEveryDamnDay.Migrations
{
    public partial class RemovedPoseId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PoseRelationship_Pose_PrepPoseId",
                table: "PoseRelationship");

            migrationBuilder.DropIndex(
                name: "IX_PoseRelationship_PrepPoseId",
                table: "PoseRelationship");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PoseRelationship");

            migrationBuilder.DropColumn(
                name: "PrepPoseId",
                table: "PoseRelationship");

            migrationBuilder.AddColumn<int>(
                name: "PrepPosePoseId",
                table: "PoseRelationship",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PoseRelationship_PrepPosePoseId",
                table: "PoseRelationship",
                column: "PrepPosePoseId");

            migrationBuilder.AddForeignKey(
                name: "FK_PoseRelationship_Pose_PrepPosePoseId",
                table: "PoseRelationship",
                column: "PrepPosePoseId",
                principalTable: "Pose",
                principalColumn: "PoseId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PoseRelationship_Pose_PrepPosePoseId",
                table: "PoseRelationship");

            migrationBuilder.DropIndex(
                name: "IX_PoseRelationship_PrepPosePoseId",
                table: "PoseRelationship");

            migrationBuilder.DropColumn(
                name: "PrepPosePoseId",
                table: "PoseRelationship");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PoseRelationship",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrepPoseId",
                table: "PoseRelationship",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PoseRelationship_PrepPoseId",
                table: "PoseRelationship",
                column: "PrepPoseId");

            migrationBuilder.AddForeignKey(
                name: "FK_PoseRelationship_Pose_PrepPoseId",
                table: "PoseRelationship",
                column: "PrepPoseId",
                principalTable: "Pose",
                principalColumn: "PoseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
