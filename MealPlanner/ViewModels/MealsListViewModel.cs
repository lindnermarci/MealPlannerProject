using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MealPlanner.ViewModels
{
    public class MealsListViewModel
    {
        public IEnumerable<Meal> Meals { get; set; }

        public string CurrentCategory { get; set; }


    }
}
