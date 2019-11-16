using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    [Route("MyAccount")]
    public class AccountController : Controller
    {
        [HttpGet]
        [Route("MyLogin")]
        [Route("Login")]
        [Route("YourLogin")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ValidateLogin(Login login)
        {
            if (login.EmailId == "rahul@gmail.com" && login.Password == "123")
            {
                return RedirectToAction("Sample", "Student");
            }
            else
            {
                ModelState.AddModelError("ErrorMessage", "Invalid Email ID or Password.");
                return View("Login", login);
            }
        }
    }
}