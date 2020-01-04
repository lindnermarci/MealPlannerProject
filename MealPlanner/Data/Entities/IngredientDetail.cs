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
        public int Id { get; set; }
        public int IngredientId { get; set; }
        public double Amount { get; set; }
        public int MealId { get; set; }
    }
}
