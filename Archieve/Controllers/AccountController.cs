using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archieve.DataAccess.ViewModel;
using Archieve.DatabaseLayer.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Archieve.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public IActionResult Index()
        {
            return View();
        }
        public AccountController(
                                  UserManager<User> userManager, 
                                  SignInManager<User> signInManager
                                )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View(new UserVM());
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserVM model ,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.UserName,
                    //Email = model.Email
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // var token = await userManager.GenerateEmailConfirmationTokenAsync(user);

                    return View();
                }

            }
            return View(new UserVM());
        }
        //public async Task<IActionResult> Login(string returnUrl = null)
        //{
        //    //if (!string.IsNullOrEmpty(ErrorMessage))
        //    //{
        //    //    ModelState.AddModelError(string.Empty, ErrorMessage);
        //    //}

        //    returnUrl = returnUrl ?? Url.Content("~/");

        //    // Clear the existing external cookie to ensure a clean login process
        //    await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);



        //    ViewBag.ReturnUrl = returnUrl;
        //    return View();
        //}
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken()]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                await userManager.FindByNameAsync(model.UserName);
              var result=  await signInManager.PasswordSignInAsync(model.UserName, model.Password, 
                                                                   model.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home"); 
                }
                if (result.IsLockedOut)
                {
                return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }
                
            }
            return View();
        }
    }
}
