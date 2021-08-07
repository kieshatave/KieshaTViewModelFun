using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            HomeString welcomeMessage = new HomeString()
            {
                WelcomeMessage = "A message from the controller"
            };
            string WelcomeMessage = "Welcome!";
            return View("Index", WelcomeMessage);
        }

        [HttpGet("Numbers")]
        public IActionResult Numbers()
        {
            int[] someNumbers = { 1, 2, 3, 4, 5, 6 };

            return View("Numbers", someNumbers);
        }

        [HttpGet("Users")]
        public IActionResult Users()
        {
            User someUser = new User()
            {
                FirstName = "John",
                LastName = "Smith"
            };

            User newUser = new User()
            {
                FirstName = "Jane",
                LastName = "Doe"
            };


            List <User> viewModel = new List<User>()
            {
                someUser, newUser
            };

            return View("Users", viewModel);
        }

        [HttpGet("User")]
        public IActionResult User()
        {
            User newUser = new User()
            {
                FirstName = "Jane",
                LastName = "Doe"
            };

            return View("User", newUser);
        }
    }
}