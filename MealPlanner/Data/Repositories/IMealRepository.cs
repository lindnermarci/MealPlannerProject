using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Data.Entities;

namespace MealPlanner.Models.Repositories
{
    public interface IMealRepository
    {
        IEnumerable<Meal> AllMeals { get; }
        IEnumerable<Meal> MealsOfTheWeek { get; }

        Meal GetMealById(int MealId);
        void AddPersonalMeals(MealPlan mealPlan, int calories);
        List<Ingredient> GetMealIngredients(int mealId);
        List<IngredientDetail> GetIngredientDetails(int mealId);
        int GetFatContent(int mealId);
        int GetProteinContent(int mealId);
        int GetCarbohidrateContent(int mealId);
    }
}
