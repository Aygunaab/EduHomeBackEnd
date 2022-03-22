using EduHome.Models;
using EduHome.Services;
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
        private readonly IMailService _mailservice;
        private readonly SignInManager<User> _signinManager;

        public AccountController(UserManager<User> usermanager, IMailService mailservice, SignInManager<User> signinManager)
        {
            _usermanager = usermanager;
            _mailservice = mailservice;
            _signinManager=signinManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVm model)
        {
            if (!ModelState.IsValid) return View();

            var user = await _usermanager.FindByNameAsync(model.Login);
            if (user == null) user = await _usermanager.FindByEmailAsync(model.Login);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid credentials");
                return View();
            }

            if (!user.IsActive)
            {
                ModelState.AddModelError("", "Your account was blocked by admin");
                return View();
            }

            var signinResult = await _signinManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", "Invalid Credentials");
                return View();
            }

            return RedirectToAction("Index", "Home");

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
            var token =await _usermanager.GenerateEmailConfirmationTokenAsync(newuser);
            var link = Url.Action(nameof(ConfirmEmail), "Account", new { newuser.UserName, token }, Request.Scheme);
            await _mailservice.SendEmailAsync(new MailRequest
            {
                ToEmail = newuser.Email,
                Subject = "Complete registration",
                Body = link
            });

            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ConfirmEmail(string username,string token)
        {
            var user = await _usermanager.FindByNameAsync(username);
            if (user == null) return BadRequest();
            var Identityresult=await _usermanager.ConfirmEmailAsync(user, token);
            if(!Identityresult.Succeeded)
            {
                return BadRequest();
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
