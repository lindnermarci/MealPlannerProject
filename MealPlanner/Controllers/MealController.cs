using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MealPlanner.Models;
using MealPlanner.ViewModels;
using MealPlanner.Models.Repositories;

namespace MealPlanner.Controllers
{
    public class MealController : Controller
    {
        private readonly ILogger<MealController> _logger;
        private readonly IMealRepository mealRepository;
        private readonly ICategoryRepository categoryRepository;

        public MealController(ILogger<MealController> logger, IMealRepository mealRepository, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            this.mealRepository = mealRepository;
            this.categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Meal> meals;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                meals = mealRepository.AllMeals.OrderBy(p => p.MealId);
                currentCategory = "All meals";
            }
            else
            {
                meals = mealRepository.AllMeals.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.MealId);
                currentCategory = categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new MealsListViewModel { 
                Meals = meals,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var meal = mealRepository.GetMealById(id);
            if (meal == null) return NotFound();
            return View(meal);
        }
    }
}
