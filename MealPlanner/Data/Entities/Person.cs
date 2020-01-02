using MealPlanner.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace MealPlanner.Models
{
    public class Person
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
        public MealPlanDetails MealPlanDetails { get; set; }

    }
}
