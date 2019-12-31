using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;

namespace MealPlanner.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Meal> MealsOfTheWeek { get; set; }
    }
}
