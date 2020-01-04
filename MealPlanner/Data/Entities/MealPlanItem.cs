using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models.Entities
{
    public class MealPlanItem
    {
        public int MealPlanItemId { get; set; }
        public Meal Meal { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public int Amount { get; set; }
        public string MealplanIdentifier { get; set; }
    }
}
