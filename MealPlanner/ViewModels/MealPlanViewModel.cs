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
        public int TDEE { get; set; }
        public int DailyCalorieAmount { get; set; }
        public int CarbsAmount { get; set; }
        public int CarbsPercent { get; set; }
        public int FatAmount { get; set; }
        public int FatPercent { get; set; }
        public int ProteinAmount { get; set; }
        public int ProteinPercent { get; set; }
    }
}
