using MealPlanner.Data.Entities;

namespace MealPlanner.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }
        public double ProteinContent { get; set; }
        public double CarbohidrateContent { get; set; }
        public double FatContent { get; set; }
        public int Calories
        {
            get
            {
                return (int)((CarbohidrateContent + ProteinContent) * 4 + FatContent * 9);
            }
        }

        //public Ingredient(int ingredientId, string name, double proteinContent, double carbohidrateContent, double fatContent, int calories)
        //{
        //    IngredientId = ingredientId;
        //    Name = name;
        //    ProteinContent = proteinContent;
        //    CarbohidrateContent = carbohidrateContent;
        //    FatContent = fatContent;
        //    Calories = calories;
        //}
    }
}