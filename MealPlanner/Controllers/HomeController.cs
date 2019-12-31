using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models.Repositories;
using MealPlanner.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMealRepository mealRepository;

        public HomeController(IMealRepository mealRepository)
        {
            this.mealRepository = mealRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                MealsOfTheWeek = mealRepository.MealsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
