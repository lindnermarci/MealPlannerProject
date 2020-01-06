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
                return appDbContext.Meals.Where(meal => meal.IsMealOfTheWeek).Include(meal => meal.Category);
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
                        if (szum + 200 < calories)
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
                if (item.Ingredient != null)
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
            var meal = appDbContext.Meals.FirstOrDefault(meal => meal.MealId == mealId);
            if (meal.IngredientDetails == null) meal.IngredientDetails = GetMealIngredientDetails(mealId);
            appDbContext.SaveChanges();
            return meal;
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
            List<IngredientDetail> ingredientDetails = appDbContext.IngredientDetails.Where(x => x.MealId == mealId).Cast<IngredientDetail>().ToList();
            foreach (var ingredientDetail in ingredientDetails)
            {
                List<Ingredient> ingredients = appDbContext.Ingredients.Cast<Ingredient>().ToList();
                if (ingredientDetail.Ingredient == null)
                {
                   // Ingredient ing = ingredients.SingleOrDefault(ing => ing.IngredientId == (ingredientDetail.IngredientId % 4 + 1));
                   // ingredientDetail.Ingredient = ing;
                }
            }
            return ingredientDetails;

        }

        public int GetProteinContent(int mealId)
        {
            throw new NotImplementedException();
        }

        public void InitialiseMeals()
        {
            IList<Meal> meals = appDbContext.Meals.Cast<Meal>().ToList();
            foreach (var meal in meals)
            {
                if (meal.IngredientDetails == null || meal.IngredientDetails.Count == 0)
                {
                    meal.IngredientDetails = appDbContext.IngredientDetails.Where(x => x.MealId == meal.MealId).Cast<IngredientDetail>().ToList();
                    foreach (var ingredientDetail in meal.IngredientDetails)
                    {
                        List<Ingredient> ingredients = appDbContext.Ingredients.Cast<Ingredient>().ToList();
                        if (ingredientDetail.Ingredient == null)
                        {
                            //Ingredient ing = ingredients.SingleOrDefault(ing => ing.IngredientId == (ingredientDetail.IngredientId % 4 + 1));
                            //ingredientDetail.Ingredient = ing;
                        }
                    }
                }
                appDbContext.SaveChanges();
            }
        }
    }
}
