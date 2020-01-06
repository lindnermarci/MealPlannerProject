using System;
using System.Collections.Generic;
using System.Linq;
using MealPlanner.Data;
using MealPlanner.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace MealPlanner.Models
{
    public class MealPlan
    {
        private readonly AppDbContext appDbContext;
        private readonly ILogger logger;

        public string MealPlanId { get; set; }
        public List<MealPlanItem> MealPlanItems { get; set; }
        private MealPlan(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public MealPlan(ILogger logger)
        {
            this.logger = logger;
        }

        public static MealPlan GetPlan(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string mealPlanId = session.GetString("MealPlanId") ?? Guid.NewGuid().ToString();

            session.SetString("MealPlanId", mealPlanId);

            return new MealPlan(context) { MealPlanId = mealPlanId };
        }

        public void AddToPlan(Meal meal, int day, int amount)
        {
                       
            var mealPlanItem =
                    appDbContext.MealPlanItems.SingleOrDefault(
                        item => item.Meal.MealId == meal.MealId && item.MealplanIdentifier == MealPlanId && item.DayOfWeek == (DayOfWeek)day);

            if (mealPlanItem == null)
            {
                mealPlanItem = new MealPlanItem
                {
                    MealplanIdentifier = MealPlanId,
                    Meal = meal,
                    Amount = amount,
                    DayOfWeek = (DayOfWeek)day
                };
                meal.ItemMealPlanId = mealPlanItem.MealPlanItemId;

                appDbContext.MealPlanItems.Add(mealPlanItem);

            }
            else
            {
                mealPlanItem.Amount++;
            }

            appDbContext.SaveChanges();


        }

        internal void RemoveAllFromPlan()
        {
            
            var mealPlanItems = appDbContext.MealPlanItems;
            foreach (var item in mealPlanItems)
            {
                mealPlanItems.Remove(item);
            }
            MealPlanItems?.Clear();
        }

        public int RemoveFromPlan(Meal meal, int dayOfWeek)
        {
            var mealPlanItem =
                    appDbContext.MealPlanItems.SingleOrDefault(
                        item => item.Meal.MealId == meal.MealId && item.MealplanIdentifier == MealPlanId && item.DayOfWeek == (DayOfWeek)dayOfWeek);

            var localAmount = 0;

            if (mealPlanItem != null)
            {
                    appDbContext.MealPlanItems.Remove(mealPlanItem);
            }

            appDbContext.SaveChanges();

            return localAmount;
        }

        public List<MealPlanItem> GetMealPlanItems()
        {
           MealPlanItems =
                       appDbContext.MealPlanItems.Where(c => c.MealplanIdentifier == MealPlanId)
                           .Include(s => s.Meal)
                           .Include(s => s.Meal.IngredientDetails)
                           .ToList();
            return MealPlanItems;
            //foreach (var item in MealPlanItems)
            //{
            //    if(item.Meal.IngredientDetails == null)
            //    {
            //        item.Meal.IngredientDetails = 
            //    }
            //}
        }

        public void ClearMealPlan()
        {
            var mealPlanItems = appDbContext
                .MealPlanItems
                .Where(x => x.MealplanIdentifier == MealPlanId);

            appDbContext.MealPlanItems.RemoveRange(mealPlanItems);

            appDbContext.SaveChanges();
        }

        public List<decimal> GetMealPlanTotalCalories()
        {
            decimal[] calories = new decimal[7];

            var total = appDbContext.MealPlanItems.Where(x => x.MealplanIdentifier == MealPlanId);

            foreach (var item in total)
            {
                switch (item.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        calories[0] += item.Amount * item.Meal.Calories;
                        break;
                    case DayOfWeek.Monday:
                        calories[1] += item.Amount * item.Meal.Calories;
                        break;
                    case DayOfWeek.Tuesday:
                        calories[2] += item.Amount * item.Meal.Calories;
                        break;
                    case DayOfWeek.Wednesday:
                        calories[3] += item.Amount * item.Meal.Calories;
                        break;
                    case DayOfWeek.Thursday:
                        calories[4] += item.Amount * item.Meal.Calories;
                        break;
                    case DayOfWeek.Friday:
                        calories[5] += item.Amount * item.Meal.Calories;
                        break;
                    case DayOfWeek.Saturday:
                        calories[6] += item.Amount * item.Meal.Calories;
                        break;
                    default:
                        break;
                }
            }
            return calories.ToList();
        }
        public int TotalCalories
        {
            get
            {
                int szum = 0;
                var mealPlanItems = GetMealPlanItems();
                if (mealPlanItems != null)
                {
                    foreach (var item in mealPlanItems)
                    {
                        szum += item.Meal.Calories;
                    }
                    return szum;
                }
                return 0;
            }
        }
    }
}
