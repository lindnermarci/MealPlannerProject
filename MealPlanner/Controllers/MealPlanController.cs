using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;
using MealPlanner.Models.Repositories;
using MealPlanner.Modles.Repositories;
using MealPlanner.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    [Authorize]
    public class MealPlanController:Controller
    {
        private readonly IMealRepository mealRepository;
        private readonly MealPlan mealPlan;
        private readonly IPersonRepository personRepository;
        private readonly UserManager<User> userManager;
        private bool personalised;


        public MealPlanController(IMealRepository mealRepository, MealPlan mealPlan, IPersonRepository personRepository, UserManager<User> userManager)
        {
            this.mealRepository = mealRepository;
            this.mealPlan = mealPlan;
            this.personRepository = personRepository;
            this.userManager = userManager;
        }
        public ViewResult Index()
        {
            var id = userManager.GetUserId(User); // Get user id:
            var user = personRepository.getUser(id);
            var totalCalories = personRepository.getUserDailyCalories(id);
            if (!personalised)
            {
                mealRepository.AddPersonalMeals(mealPlan,  totalCalories);
                personalised = true;
            }

            var items = mealPlan.GetMealPlanItems();

            

            mealPlan.MealPlanItems = items;
            ClaimsPrincipal currentUser = this.User;

            var TDEE = personRepository.calculateUserTDEE(id);
            List<int> macros = personRepository.calculateMacros(id);
            int proteinPercent = (int)Math.Round((double)macros.ElementAt(0) * 4 / totalCalories * 100);
            int fatPercent = (int)Math.Round((double)macros.ElementAt(1) * 9 / totalCalories * 100);
            int carbsPercent = (int)Math.Round((double)macros.ElementAt(2) * 4 / totalCalories * 100);


            var mealPlanViewModel = new MealPlanViewModel()
            {
                MealPlan = mealPlan,
                TDEE = personRepository.calculateUserTDEE(id),
                TotalCalories = mealPlan.GetMealPlanTotalCalories(),
                DailyCalorieAmount = totalCalories,
                ProteinAmount = macros.ElementAt(0),
                FatAmount = macros.ElementAt(1),
                CarbsAmount = macros.ElementAt(2),
                ProteinPercent = proteinPercent,
                CarbsPercent = carbsPercent,
                FatPercent = fatPercent
            };
            mealPlanViewModel.MealPlan.MealPlanItems.OrderBy(x => x.DayOfWeek);
            return View(mealPlanViewModel);
        }

        public RedirectToActionResult AddToMealPlan(int day, int mealId)
        {
            Meal selectedMeal = mealRepository.AllMeals.FirstOrDefault(p => p.MealId == mealId);

            if (selectedMeal != null)
            {
                mealPlan.AddToPlan(selectedMeal,day , 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromMealPlan(int mealId, DayOfWeek dayOfWeek)
        {
            var selectedPie = mealRepository.AllMeals.FirstOrDefault(p => p.MealId == mealId);

            if (selectedPie != null)
            {
                mealPlan.RemoveFromPlan(selectedPie, (int)dayOfWeek);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearMealPlan()
        {

            mealPlan.ClearMealPlan();
            return RedirectToAction("Index");
        }


    }
}
