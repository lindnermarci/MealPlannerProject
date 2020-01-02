using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;

namespace MealPlanner.ViewModels
{
    public class PersonViewModel
    {
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        [Range(14, 120)]
        public int Age { get; set; }
        [Range(20, 140)]
        public int Weight { get; set; }
        public Gender Gender { get; set; }
        [Range(80, 240)]
        public int Height { get; set; }
        [Range(3, 7)]
        public int NumOfMealsPerDay { get; set; }
        [Range(5, 16)]
        public int SleepDaily { get; set; }
        [Range(1.2, 1.9)]
        public decimal ActivityFactor { get; set; }
        [Range(4, 60)]
        public int BodyFatPercentage { get; set; }
        [Range(3000, 10000)]
        public int PredictedYearlyMuscleGain { get; set; }

    }
}
