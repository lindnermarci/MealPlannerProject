using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanner.Migrations
{
    public partial class Ingredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredient_Meals_MealId",
                table: "Ingredient");

            migrationBuilder.DropIndex(
                name: "IX_Ingredient_MealId",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "FiberContent",
                table: "Ingredient");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "Ingredient");

            migrationBuilder.AlterColumn<double>(
                name: "ProteinContent",
                table: "Ingredient",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "FatContent",
                table: "Ingredient",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "CarbohidrateContent",
                table: "Ingredient",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "IngredientDetail",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientId = table.Column<int>(nullable: true),
                    Amount = table.Column<double>(nullable: false),
                    MealId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientDetail", x => x.id);
                    table.ForeignKey(
                        name: "FK_IngredientDetail_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IngredientDetail_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "MealId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IngredientDetail_IngredientId",
                table: "IngredientDetail",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientDetail_MealId",
                table: "IngredientDetail",
                column: "MealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IngredientDetail");

            migrationBuilder.AlterColumn<int>(
                name: "ProteinContent",
                table: "Ingredient",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "FatContent",
                table: "Ingredient",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "CarbohidrateContent",
                table: "Ingredient",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<int>(
                name: "FiberContent",
                table: "Ingredient",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MealId",
                table: "Ingredient",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_MealId",
                table: "Ingredient",
                column: "MealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredient_Meals_MealId",
                table: "Ingredient",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "MealId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
