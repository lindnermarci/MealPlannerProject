using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanner.Migrations
{
    public partial class IngredientDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDetail_Ingredient_IngredientId",
                table: "IngredientDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDetail_Meals_MealId",
                table: "IngredientDetail");

            migrationBuilder.DropIndex(
                name: "IX_IngredientDetail_IngredientId",
                table: "IngredientDetail");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "IngredientDetail",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "MealId",
                table: "IngredientDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IngredientId",
                table: "IngredientDetail",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "Id", "Calories", "CarbohidrateContent", "FatContent", "Name", "ProteinContent" },
                values: new object[,]
                {
                    { 1, 24, 5.0, 0.29999999999999999, "califlower", 1.8999999999999999 },
                    { 2, 440, 18.0, 5.0, "nuts", 13.0 },
                    { 3, 50, 8.0, 0.0, "califlower", 4.7999999999999998 },
                    { 4, 51, 0.0, 0.0, "eggwhite", 11.0 }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealId", "Calories", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "IsMealOfTheWeek", "LongDescription", "Name", "PreparationTime", "ShortDescription" },
                values: new object[] { 12, 220, 2, "~/images/cal.jpg", "~/images/cal.jpg", true, "1) Chop cauliflower in food processor or use pre-chopped cauliflower.2) Weigh out cauliflower and cook in microwave for 10 minutes.3) Weigh out soy sauce and put in frying pan on medium heat.4) Add hot, cooked cauliflower and simmer till dry.5) Add egg whites and cook till done.6) Weigh nuts and sprinkle on top.", "Cauliflower Egg White Scramble ", 0, "Our famous egg scramble!" });

            migrationBuilder.InsertData(
                table: "IngredientDetail",
                columns: new[] { "Id", "Amount", "IngredientId", "MealId" },
                values: new object[,]
                {
                    { 1, 261.0, 1, 12 },
                    { 2, 62.0, 2, 12 },
                    { 3, 23.699999999999999, 3, 12 },
                    { 4, 9.0, 4, 12 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDetail_Meals_MealId",
                table: "IngredientDetail",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "MealId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientDetail_Meals_MealId",
                table: "IngredientDetail");

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredient",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IngredientDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IngredientDetail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IngredientDetail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IngredientDetail",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 12);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "IngredientDetail",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "MealId",
                table: "IngredientDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "IngredientId",
                table: "IngredientDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_IngredientDetail_IngredientId",
                table: "IngredientDetail",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDetail_Ingredient_IngredientId",
                table: "IngredientDetail",
                column: "IngredientId",
                principalTable: "Ingredient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientDetail_Meals_MealId",
                table: "IngredientDetail",
                column: "MealId",
                principalTable: "Meals",
                principalColumn: "MealId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
