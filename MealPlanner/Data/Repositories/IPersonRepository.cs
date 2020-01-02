using MealPlanner.Models;

namespace MealPlanner.Modles.Repositories
{
    public interface IPersonRepository
    {
        void savePerson(Person person);
        Person getPerson();
        float calculateTDEE();
        //int calculateRequiredDailyProtein();
        //int calculateYearlyMuscleGain();
    }
}