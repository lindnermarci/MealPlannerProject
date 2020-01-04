﻿using System.Collections.Generic;
using MealPlanner.Data.Entities;

namespace MealPlanner.Models
{
    public class Meal
    {
        public int MealId { get; set; }
        public int ItemMealPlanId { get; set; }
        public string Name { get; set; }
        public List<IngredientDetail> IngredientDetails{ get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int PreparationTime { get; set; }
        public bool IsMealOfTheWeek { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Calories { get; set; }
    }
}