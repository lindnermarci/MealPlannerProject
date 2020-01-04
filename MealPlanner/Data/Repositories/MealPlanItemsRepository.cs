using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Models.Entities;

namespace MealPlanner.Data.Repositories
{
    public class MealPlanItemsRepository : IMealPlanItemRepository
    {
        private readonly AppDbContext appDbContext;

        public MealPlanItemsRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IEnumerable<MealPlanItem> AllMealPlanItems
        {
            get
            {
                return appDbContext.MealPlanItems;
            }
        }
    }
}
