namespace MealPlanner.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double ProteinContent { get; set; }
        public double CarbohidrateContent { get; set; }
        public double FatContent { get; set; }
        public int Calories { get; set; }

        public Ingredient(int id, string name, double proteinContent, double carbohidrateContent, double fatContent, int calories)
        {
            Id = id;
            Name = name;
            ProteinContent = proteinContent;
            CarbohidrateContent = carbohidrateContent;
            FatContent = fatContent;
            Calories = calories;
        }
    }
}