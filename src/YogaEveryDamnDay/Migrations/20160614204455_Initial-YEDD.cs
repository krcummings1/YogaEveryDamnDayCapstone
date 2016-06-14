using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace YogaEveryDamnDay.Migrations
{
    public partial class InitialYEDD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PoseType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Pose",
                columns: table => new
                {
                    PoseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Base64Image = table.Column<byte[]>(nullable: true),
                    CommonName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Sanskrit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pose", x => x.PoseId);
                });

            migrationBuilder.CreateTable(
                name: "PoseCategory",
                columns: table => new
                {
                    PoseCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    PoseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoseCategory", x => x.PoseCategoryId);
                    table.ForeignKey(
                        name: "FK_PoseCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PoseCategory_Pose_PoseId",
                        column: x => x.PoseId,
                        principalTable: "Pose",
                        principalColumn: "PoseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PoseRelationship",
                columns: table => new
                {
                    PoseRelationshipId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BasePosePoseId = table.Column<int>(nullable: true),
                    Id = table.Column<int>(nullable: false),
                    PrepPoseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoseRelationship", x => x.PoseRelationshipId);
                    table.ForeignKey(
                        name: "FK_PoseRelationship_Pose_BasePosePoseId",
                        column: x => x.BasePosePoseId,
                        principalTable: "Pose",
                        principalColumn: "PoseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PoseRelationship_Pose_PrepPoseId",
                        column: x => x.PrepPoseId,
                        principalTable: "Pose",
                        principalColumn: "PoseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PoseCategory_CategoryId",
                table: "PoseCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PoseCategory_PoseId",
                table: "PoseCategory",
                column: "PoseId");

            migrationBuilder.CreateIndex(
                name: "IX_PoseRelationship_BasePosePoseId",
                table: "PoseRelationship",
                column: "BasePosePoseId");

            migrationBuilder.CreateIndex(
                name: "IX_PoseRelationship_PrepPoseId",
                table: "PoseRelationship",
                column: "PrepPoseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoseCategory");

            migrationBuilder.DropTable(
                name: "PoseRelationship");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Pose");
        }
    }
}
