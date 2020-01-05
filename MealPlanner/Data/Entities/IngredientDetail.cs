﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;

namespace MealPlanner.Data.Entities
{
    public class IngredientDetail
    {
        public int Id { get; set; }
        public Ingredient Ingredient{ get; set; }
        public Meal Meal { get; set; }
        public int MealId { get; set; }
        public double Amount { get; set; }
    }
}
