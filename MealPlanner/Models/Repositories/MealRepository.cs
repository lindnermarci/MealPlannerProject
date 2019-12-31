using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Data;
using Microsoft.EntityFrameworkCore;

namespace MealPlanner.Models.Repositories
{
    public class MealRepository : IMealRepository
    {
        private readonly AppDbContext appDbContext;

        public MealRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<Meal> AllMeals
        {
            get
            {
                return appDbContext.Meals.Include(meal => meal.Category);
            }
        }

        public IEnumerable<Meal> MealsOfTheWeek
        {
            get
            {
                return appDbContext.Meals.Where(meal => meal.IsMealOfTheWeek).Include(meal => meal.Category);
            }
        }

        public Meal GetMealById(int mealId)
        {
            return appDbContext.Meals.FirstOrDefault(meal => meal.MealId == mealId);
        }
    }
}
