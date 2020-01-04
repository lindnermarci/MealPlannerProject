using MealPlanner.Data.Entities;
using MealPlanner.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace MealPlanner.Models
{
    public class User : IdentityUser
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public Gender Gender { get; set; }
        public int Height { get; set; }
        public int NumOfMealsPerDay { get; set; }
        public int SleepDaily { get; set; }
        public float ActivityFactor { get; set; }
        public int BodyFatPercentage { get; set; }
        public int PredictedYearlyMuscleGain { get; set; }
        public MealPlan MealPlan { get; set; }

        public decimal CalorieSurplus { get; set; }

        public NutritionType NutritionType{ get; set; }

    }
}
