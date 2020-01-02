using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealPlanner.Data;
using MealPlanner.Models;
using MealPlanner.Models.Entities;

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
        public float calculateTDEE()
        {
            var person = appDbContext.People.FirstOrDefault();
            double RMR = 0;
            if (person != null)
            {
                if (person.Gender == Gender.MALE)
                {
                    //Miffin-St. Jeor formula
                    RMR = 9.99 * person.Weight + 6.25 * person.Height - 4.92 * person.Age + 5;
                }
                else
                {
                    //Miffin-St. Jeor formula
                    RMR = 9.99 * person.Weight + 6.25 * person.Height - 4.92 * person.Age - 161;
                }
                return person.ActivityFactor * (float)RMR;
            }
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

        public Person getPerson()
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
            .HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string mealPlanId = session.GetString("MealPlanId") ?? Guid.NewGuid().ToString();

            session.SetString("MealPlanId", mealPlanId);
            return appDbContext.People.FirstOrDefault();
        }

        public void savePerson(Person person)
        {
            person.MealPlanDetails = (new MealPlanDetails
            {
                MealPlan = mealPlan,
                Created = DateTime.Now
            });

            appDbContext.People.Add(person);


            appDbContext.SaveChanges();
        }

       
    }
}
