using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models.Entities;

namespace MealPlanner.Data.Repositories
{
    public interface IMealPlanItemRepository
    {
        IEnumerable<MealPlanItem> AllMealPlanItems { get; }
    }
}
