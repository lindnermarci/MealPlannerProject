using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;

namespace MealPlanner.ViewModels
{
    public class PersonViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public int Height { get; set; }
        public int NumOfMealsPerDay { get; set; }
        public int SleepDaily { get; set; }
        public int CardioWeekly { get; set; }
        public int BodyFatPercentage { get; set; }
        public int PredictedYearlyMuscleGain { get; set; }

    }
}
