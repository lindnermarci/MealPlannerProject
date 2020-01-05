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

        public void AddMealIngredients()
        {
            //List<IngredientDetail> details = new List<IngredientDetail>();
            //for (int i = 1; i <= appDbContext.IngredientDetails.Count(); i++)
            //{
            //    //appDbContext.IngredientDetails.Where(detail => detail.Id == i).FirstOrDefault().Ingredient = appDbContext.Ingredients.Where(ing => ing.IngredientId == i).FirstOrDefault();
            //    details.Add(appDbContext.IngredientDetails.Where(detail => detail.Id == i).FirstOrDefault());
            //}
            ////appDbContext.SaveChanges();

            //    meal.IngredientDetails = details;

            //appDbContext.SaveChanges();
            //var ingredientDet = appDbContext.IngredientDetails.FirstOrDefault();
            //ingredientDet.Ingredient = appDbContext.Ingredients.Where(ing => ing.IngredientId == 1).FirstOrDefault();
            //appDbContext.SaveChanges();
            //Meal meal = appDbContext.Meals.Where(meal => meal.MealId == 12).FirstOrDefault();
            ////foreach (Meal item in appDbContext.Meals)
            ////{
            ////    if(item != null)
            ////    item.IngredientDetails.Add(ingredientDet);
            ////}
            //meal.IngredientDetails.Add(ingredientDet);
            //appDbContext.SaveChanges();



        }

        public Meal GetMealById(int mealId)
        {
            var meal = appDbContext.Meals.FirstOrDefault(meal => meal.MealId == mealId);
            if(meal.IngredientDetails == null)
            {
                meal.IngredientDetails = appDbContext.IngredientDetails.Where(x => x.MealId == mealId).Cast<IngredientDetail>().ToList();
                foreach (var ingredientDetail in meal.IngredientDetails)
                {
                    List<Ingredient> ingredients = appDbContext.Ingredients.Cast<Ingredient>().ToList();
                    if (ingredientDetail.Ingredient == null)
                    {
                        
                        ingredientDetail.Ingredient = ingredients.SingleOrDefault(ing => ing.IngredientDetailId == (ingredientDetail.Id % 4 + 1));
                    }

                }
            }
            appDbContext.SaveChanges();
            return meal;
        }
    }
}
