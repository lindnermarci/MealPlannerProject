namespace MealPlanner.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProteinContent { get; set; }
        public int CarbohidrateContent { get; set; }
        public int FatContent { get; set; }
        public int Calories { get; set; }
        public int FiberContent { get; set; }
    }
}