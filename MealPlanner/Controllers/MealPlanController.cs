using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;
using MealPlanner.Models.Repositories;
using MealPlanner.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    [Authorize]
    public class MealPlanController:Controller
    {
        private readonly IMealRepository mealRepository;
        private readonly MealPlan mealPlan;

        public MealPlanController(IMealRepository mealRepository, MealPlan mealPlan)
        {
            this.mealRepository = mealRepository;
            this.mealPlan = mealPlan;
        }

        public ViewResult Index()
        {
            var items = mealPlan.GetMealPlanItems();

            mealPlan.MealPlanItems = items;

            var mealPlanViewModel = new MealPlanViewModel()
            {
                MealPlan = mealPlan,
                TotalCalories = mealPlan.GetMealPlanTotalCalories()
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

        public RedirectToActionResult RemoveFromMealPlan(int mealId)
        {
            var selectedPie = mealRepository.AllMeals.FirstOrDefault(p => p.MealId == mealId);

            if (selectedPie != null)
            {
                mealPlan.RemoveFromPlan(selectedPie);
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
