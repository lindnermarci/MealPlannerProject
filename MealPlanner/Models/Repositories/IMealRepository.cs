using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models.Repositories
{
    public interface IMealRepository
    {
        IEnumerable<Meal> AllMeals { get; }
        IEnumerable<Meal> MealsOfTheWeek { get; }

        Meal GetMealById(int MealId);
    }
}
