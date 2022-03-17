using EduHome.Models;
using EduHome.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _usermanager;

        public AccountController(UserManager<User> usermanager)
        {
            _usermanager = usermanager;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Register(RegisterVm model)
        {
            if (!ModelState.IsValid) return View();
            var user = await _usermanager.FindByNameAsync(model.UserName);
            if(user != null)
            {
                ModelState.AddModelError("UserName", "Bu adda user movcuddur");
                return View();
            }
            User newuser = new User
            {
                FulName = model.FullName,
                UserName = model.UserName,
                Email = model.Email,
                Age = model.Age,
                Position = model.Position,

            };
          IdentityResult identityresult=await _usermanager.CreateAsync(newuser, model.Password);
            if (!identityresult.Succeeded)
            {
                foreach (var error in identityresult.Errors)
                {
                    ModelState.AddModelError(" ", error.Description);
                }
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
