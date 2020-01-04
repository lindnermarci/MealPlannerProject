using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MealPlanner.Models;
using MealPlanner.Modles.Repositories;
using MealPlanner.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    [Authorize]
    public class PersonController:Controller
    {
        private readonly IPersonRepository personRepository;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;

        public PersonController(IPersonRepository personRepository, IMapper mapper, UserManager<User> userManager)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult PersonInformation()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult PersonSave(PersonViewModel model)
        {
            var person = mapper.Map<User>(model);
            personRepository.saveUser(person);
            return RedirectToAction("PersonSaveComplete");
        }

        public IActionResult PersonSaveComplete()
        {
            var id = userManager.GetUserId(User); // Get user id:

            var person = personRepository.getUser(id);
            var personView = mapper.Map<PersonViewModel>(person);
            return View(personView);
        }
    }
}
