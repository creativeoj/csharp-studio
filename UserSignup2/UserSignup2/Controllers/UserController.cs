using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup2.Models;

namespace UserSignup2.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {

            if(user.Password != verify)
            {
                ModelState.AddModelError("verifyError", "Passwords must match");
                return View("Add", user);
            }

            if(user.Username == "")
            {
                ModelState.AddModelError("userError", "Please enter a username");
                return View("Add", user);
            }

            return View("Index", user);
        }
    }
}