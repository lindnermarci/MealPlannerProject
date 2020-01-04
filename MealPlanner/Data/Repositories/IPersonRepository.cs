using System.Collections.Generic;
using MealPlanner.Models;

namespace MealPlanner.Modles.Repositories
{
    public interface IPersonRepository
    {
        void saveUser(User person);
        User getUser(string id);
        int calculateUserTDEE(string id);

        int getUserDailyCalories(string id);
        int calculateCalorieGoal(string id);
        List<int> calculateMacros(string id);
    }
}