using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MealPlanner.Models;
using MealPlanner.ViewModels;

namespace MealPlanner.Data
{
    public class MealProfile:Profile
    {
        public MealProfile()
        {
            this.CreateMap<User, PersonViewModel>()
                .ReverseMap();
        }
    }
}
