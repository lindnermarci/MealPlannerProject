using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanner.Migrations
{
    public partial class MEalPlanDetailsDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MealPlanDetail_MealPlanDetailsMealPlanDetailId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MealPlanDetail");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MealPlanDetailsMealPlanDetailId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MealPlanDetailsMealPlanDetailId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "MealPlanId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MealPlanId",
                table: "AspNetUsers",
                column: "MealPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MealPlan_MealPlanId",
                table: "AspNetUsers",
                column: "MealPlanId",
                principalTable: "MealPlan",
                principalColumn: "MealPlanId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_MealPlan_MealPlanId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MealPlanId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MealPlanId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "MealPlanDetailsMealPlanDetailId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MealPlanDetail",
                columns: table => new
                {
                    MealPlanDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MealPlanId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlanDetail", x => x.MealPlanDetailId);
                    table.ForeignKey(
                        name: "FK_MealPlanDetail_MealPlan_MealPlanId",
                        column: x => x.MealPlanId,
                        principalTable: "MealPlan",
                        principalColumn: "MealPlanId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MealPlanDetailsMealPlanDetailId",
                table: "AspNetUsers",
                column: "MealPlanDetailsMealPlanDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlanDetail_MealPlanId",
                table: "MealPlanDetail",
                column: "MealPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_MealPlanDetail_MealPlanDetailsMealPlanDetailId",
                table: "AspNetUsers",
                column: "MealPlanDetailsMealPlanDetailId",
                principalTable: "MealPlanDetail",
                principalColumn: "MealPlanDetailId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
