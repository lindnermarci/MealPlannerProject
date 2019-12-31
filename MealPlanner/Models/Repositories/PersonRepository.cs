using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Data;
using MealPlanner.Models;

namespace MealPlanner.Modles.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext appDbContext;
        private readonly MealPlan mealPlan;

        public PersonRepository(AppDbContext appDbContext, MealPlan mealPlan)
        {
            this.appDbContext = appDbContext;
            this.mealPlan = mealPlan;
        }
        public int calculateRequiredDailyCalories()
        {
            return 0;
        }

        public int calculateRequiredDailyProtein()
        {
            return 0;
        }

        public int calculateYearlyMuscleGain()
        {
            return 0;
        }

        public void CreatePerson(Person person)
        {
           // person.MealPlans.Add(mealPlan);

            appDbContext.People.Add(person);


            appDbContext.SaveChanges();
        }
    }
}
