using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Data;
using MealPlanner.Models;
using MealPlanner.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace MealPlanner.Modles.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly MealPlan mealPlan;

        public PersonRepository(AppDbContext appDbContext, MealPlan mealPlan)
        {
            this.appDbContext = appDbContext;
            this.mealPlan = mealPlan;
            this.mealPlan = mealPlan;        
        }

        public int calculateCalorieGoal(string id)
        {
            var user = appDbContext.Users.Where(p => p.Id.Equals(id)).FirstOrDefault();
            return (int)(calculateUserTDEE(id) * user.CalorieSurplus);
        }
        public List<int> calculateMacros(string id)
        {
            var totalCalories = calculateCalorieGoal(id);
            var user = appDbContext.Users.Where(p => p.Id.Equals(id)).FirstOrDefault();
            double proteinCalories = user.Weight * 2 * 4;
            double fatCalories = 0;
            switch (user.NutritionType)
            {
                case Data.Entities.NutritionType.FAT:
                    fatCalories = (int)Math.Round(totalCalories * 0.48);
                    break;
                case Data.Entities.NutritionType.CARB:
                    fatCalories = (int)Math.Round(totalCalories * 0.23);
                    break;
                default:
                    break;
            }
            double carbCalories = totalCalories - proteinCalories - fatCalories;
            return new List<int>() { (int)Math.Round(proteinCalories / 4), (int)Math.Round(fatCalories / 9), (int)Math.Round(carbCalories / 4) };
        }

        public int calculateUserTDEE(string id)
        {
            var user = appDbContext.Users.Where(p => p.Id.Equals(id)).FirstOrDefault();
            double RMR = 0;
            if (user != null)
            {
                if (user.Gender == Gender.MALE)
                {
                    //Miffin-St. Jeor formula
                    RMR = 9.99 * user.Weight + 6.25 * user.Height - 4.92 * user.Age + 5;
                }
                else
                {
                    //Miffin-St. Jeor formula
                    RMR = 9.99 * user.Weight + 6.25 * user.Height - 4.92 * user.Age - 161;
                }
                return (int)Math.Round(user.ActivityFactor * (float)RMR);
            }
            return 0;
            
        }


        public User getUser(string id)
        {
            return appDbContext.Users.Where(p => p.Id.Equals(id)).FirstOrDefault();
        }

        public int getUserDailyCalories(string id)
        {
            int calories = (int)(getUser(id).CalorieSurplus * calculateUserTDEE(id));
            return calories;
        }

        public void saveUser(User user)
        {

            
            user.MealPlan = mealPlan;

            appDbContext.Users.Add(user);


            appDbContext.SaveChanges();
        }


    }
}
