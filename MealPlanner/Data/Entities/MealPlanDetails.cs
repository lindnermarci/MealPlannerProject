using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealPlanner.Models.Entities
{
    public class MealPlanDetails
    {
        public int MealPlanDetailsId { get; set; }
        public MealPlan MealPlan { get; set; }
        public DateTime Created { get; set; }
        public int PersonId { get; set; }
    }
}
