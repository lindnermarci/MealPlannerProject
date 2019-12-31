using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    public class PersonController:Controller
    {
        public PersonController()
        {

        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
