using MealPlanner.Models;

namespace MealPlanner.Modles.Repositories
{
    public interface IPersonRepository
    {
        void CreatePerson(Person person);
        int calculateRequiredDailyCalories();
        int calculateRequiredDailyProtein();
        int calculateYearlyMuscleGain();
    }
}