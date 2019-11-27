using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewmodel_fun.Models;

namespace viewmodel_fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string message = "Hello hellooooo hello";
            return View((object)message);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = {2,3,4,5,6,2,3,4};
            return View((object)numbers);
        }

        [HttpGet("user")]
        public IActionResult NewUser()
        {
            User someUser = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            return View(someUser);
        }
        
        [HttpGet("users")]
        public IActionResult Users()
        {
            User User1 = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };
            User User2 = new User()
            {
                FirstName = "Sarah"
            };
            User User3 = new User()
            {
                FirstName = "Jerry"
            };
            User User4 = new User()
            {
                FirstName = "Rene",
                LastName = "Ricky"
            };
            User User5 = new User()
            {
                FirstName = "Barbarah"
            };
            List<User> userList = new List<User>()
            {
               User1, User2, User3, User4, User5
            };
            return View(userList);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
