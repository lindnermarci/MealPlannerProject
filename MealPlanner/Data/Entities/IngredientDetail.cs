using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;

namespace MealPlanner.Data.Entities
{
    public class IngredientDetail
    {
        public int IngredientDetailId { get; set; }
        public Ingredient Ingredient { get; set; }
        public Meal Meal { get; set; }
        public int MealId { get; set; }
        public double Amount { get; set; }

        public double FatContent
        {
            get
            {
                if (Ingredient != null)
                return Math.Round(Amount / 100 * Ingredient.FatContent, 2);
                return 0;
            }
        }

        public double ProteinContent
        {
            get
            {
                return Math.Round(Amount / 100 * Ingredient.ProteinContent, 2);
            }
        }
        public double CarbohidrateContent
        {
            get
            {
                return Math.Round(Amount / 100 * Ingredient.CarbohidrateContent, 2);
            }
        }

        public double Calories
        {
            get
            {
                return Math.Round(Amount / 100 * Ingredient.Calories, 2);
            }
        }
    }
}
