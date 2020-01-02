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
using Microsoft.AspNetCore.Mvc;

namespace MealPlanner.Controllers
{
    [Authorize]
    public class PersonController:Controller
    {
        private readonly IPersonRepository personRepository;
        private readonly IMapper mapper;

        public PersonController(IPersonRepository personRepository, IMapper mapper)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult PersonInformation()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult PersonSave(PersonViewModel model)
        {
            var person = mapper.Map<Person>(model);
            personRepository.savePerson(person);
            return RedirectToAction("PersonSaveComplete");
        }

        public IActionResult PersonSaveComplete()
        {
            var person = personRepository.getPerson();
            var personView = mapper.Map<PersonViewModel>(person);
            return View(personView);
        }
    }
}
