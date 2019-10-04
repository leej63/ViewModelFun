using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            return View("index", message);
        }


        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = {
                1, 3, 7, 2, 8, 10
            };
            return View("numbers", numbers);
        }

        [HttpGet]
        [Route("users")]
        public IActionResult Users()
        {
            List<User> names = new List<User>()
            {
                new User("Moose", "Phillips"),
                new User("Sarah", "Smith"),
                new User("John", "Johnson"),
                new User("Rachel", "Taber"),
                new User("Rene", "Ricky")
            };
            return View("users", names);
        }

        [HttpGet("user")]
        public IActionResult OneUser()
        {
            User name = new User("Naruto", "Uzamaki");
            return View("oneuser", name);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
