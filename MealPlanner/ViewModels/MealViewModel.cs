using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MealPlanner.ViewModels
{
    public class MealViewModel
    {
        public Meal Meal { get; set; }
        public List<SelectListItem> DayOfWeek { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "MON", Text = "MOnday" },
            new SelectListItem { Value = "TUE", Text = "Tuesday" },
            new SelectListItem { Value = "WEN", Text = "Wednesday"  },
            new SelectListItem { Value = "THU", Text = "Thursday" },
            new SelectListItem { Value = "FRI", Text = "Friday" },
            new SelectListItem { Value = "SAT", Text = "Saturday"  },
            new SelectListItem { Value = "SUN", Text = "Sunday"  }
        };
    }
}
