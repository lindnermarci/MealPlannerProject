using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;

namespace MealPlanner.ViewModels
{
    public class MealPlanViewModel
    {
        public MealPlan MealPlan { get; set; }
        public List<decimal> TotalCalories { get; set; }
        public float DailyCalorieGoal { get; set; }
    }
}
