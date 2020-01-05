using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models;

namespace MealPlanner.Data.Entities
{
    public class Toy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Meal Meal{ set; get; }
        // NO OwnerID necessary
    }
}
