using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MealPlanner.Data;
using MealPlanner.Data.Entities;
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
                return appDbContext.Meals.Include(meal => meal.Category).Include(x => x.IngredientDetails).ThenInclude(x => x.Ingredient);
            }
        }

        public IEnumerable<Meal> MealsOfTheWeek
        {
            get
            {
                return appDbContext.Meals.Where(meal => meal.IsMealOfTheWeek).Include(meal => meal.Category).Include(x => x.IngredientDetails).ThenInclude(x => x.Ingredient);
            }
        }



        public void AddPersonalMeals(MealPlan mealPlan, int calories)
        {
            if (mealPlan.TotalCalories < calories)
            {
                for (int i = 0; i < 7; i++)
                {
                    var szum = 0;
                    IList<Meal> meals = appDbContext.Meals.Include(x => x.IngredientDetails).ThenInclude(x => x.Ingredient).Cast<Meal>().Where(x => x.MealId > i).ToList();
                    foreach (var item in meals)
                    {
                        if (szum < calories * 0.9)
                        {
                            mealPlan.AddToPlan(item, i, 1);
                            szum += item.Calories;
                        } 
                    }
                    szum = 0;
                }
            }



        }

        public int GetCarbohidrateContent(int mealId)
        {
            double szum = 0;
            foreach (var item in GetIngredientDetails(mealId))
            {
                szum += item.Ingredient.CarbohidrateContent;
            }
            return (int)szum;
        }

        public int GetFatContent(int mealId)
        {
            var szum = 0.0;
            foreach (var item in GetIngredientDetails(mealId))
            {
                    szum += item.Ingredient.FatContent;
            }
            return (int)szum;
        }


        public List<IngredientDetail> GetIngredientDetails(int mealId)
        {
            return appDbContext.IngredientDetails.Where(x => x.MealId == mealId).Include("Ingredient").ToList();
        }

        public Meal GetMealById(int mealId)
        {
            return appDbContext.Meals.Include(x => x.IngredientDetails).ThenInclude(x => x.Ingredient).FirstOrDefault(meal => meal.MealId == mealId);
        }

        public List<Ingredient> GetMealIngredients(int mealId)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            var ingDetails = appDbContext.IngredientDetails.Where(d => d.MealId == mealId);
            foreach (var item in ingDetails)
            {
                ingredients.Add(item.Ingredient);
            }
            return ingredients;

        }

        public List<IngredientDetail> GetMealIngredientDetails(int mealId)
        {
            return appDbContext.IngredientDetails.Where(x => x.MealId == mealId).Include(x => x.Ingredient).Cast<IngredientDetail>().ToList();

        }

        public int GetProteinContent(int mealId)
        {
            throw new NotImplementedException();
        }
    }
}
