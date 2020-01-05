using Microsoft.EntityFrameworkCore.Migrations;

namespace MealPlanner.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IngredientDetails",
                columns: new[] { "Id", "Amount", "MealId" },
                 values: new object[,]
                {
                       { 5, 261.0, 11 },
                    { 6, 261.0, 11 },
                    { 7, 261.0, 11 },
                    { 8, 261.0, 11 },
                    { 9, 261.0, 10 },
                    { 10, 261.0, 10 },
                    { 11, 261.0, 10 },
                    { 12, 261.0, 10 },
                    { 13, 261.0, 9 },
                    { 14, 261.0, 9 },
                    { 15, 261.0, 9 },
                    { 16, 261.0, 9 },
                    { 17, 261.0, 8 },
                    { 18, 261.0, 8 },
                    { 19, 261.0, 8 },
                    { 20, 261.0, 8 },
                    { 21, 261.0, 7 },
                    { 22, 261.0, 7 },
                    { 23, 261.0, 7 },
                    { 24, 261.0, 7 },
                    { 25, 261.0, 6 },
                    { 26, 261.0, 6 },
                    { 27, 261.0, 6 },
                    { 28, 261.0, 6 },
                    { 29, 261.0, 5 },
                    { 30, 261.0, 5 },
                    { 31, 261.0, 5 },
                    { 32, 261.0, 5 },
                    { 33, 261.0, 4 },
                    { 34, 261.0, 4 },
                    { 35, 261.0, 4 },
                    { 36, 261.0, 4 },
                    { 37, 261.0, 3 },
                    { 38, 261.0, 3 },
                    { 39, 261.0, 3 },
                    { 40, 261.0, 3 },
                    { 41, 261.0, 2 },
                    { 42, 261.0, 2 },
                    { 43, 261.0, 2 },
                    { 44, 261.0, 2 },
                    { 45, 261.0, 1 },
                    { 46, 261.0, 1 },
                    { 47, 261.0, 1 },
                    { 48, 261.0, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientDetails",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
