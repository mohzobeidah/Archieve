using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archieve.DataAccess.ViewModel;
using Archieve.DatabaseLayer.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Archieve.Controllers
{
    public class AdministratorController : Controller
    {
        
        private readonly IHttpContextAccessor accessor;
        private readonly IMapper mapper;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
     
        public AdministratorController(
                                  IHttpContextAccessor accessor,
                                  IMapper mapper,
                                  RoleManager<IdentityRole> roleManager,
                                  UserManager<User> userManager,
                                  SignInManager<User> signInManager
                                )
        {
            this.accessor = accessor;
            this.mapper = mapper;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoleVM role)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole();
                identityRole.Name = role.RoleName;
                var roleExist = await roleManager.RoleExistsAsync(identityRole.Name);
                if (!roleExist)
                {
                    var result = await roleManager.CreateAsync(identityRole);
                    if (result.Succeeded)
                    {
                        return View("Create");
                    }
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "الصلاحية  تم ادخالها ");
                    return View(role);
                }

            }
            return View(role);

            ////////////////////////////////////////// Another Code //////////////////////////////////////////
            //var roleExist = await roleManager.RoleExistsAsync(role.RoleName);
            //if (!roleExist)
            //{
            //    var result = await roleManager.CreateAsync(new IdentityRole(role.RoleName));
            //}
            //return View();
        }

        public async Task<IActionResult> Manage(string userId)
        {
            ViewBag.userId = userId;
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {userId} cannot be found";
                return View("NotFound");
            }

            ViewBag.UserName = user.UserName;
            var model = new List<UserRoleVM>();
            var roleList = roleManager.Roles.ToList();
            foreach (var role in roleList)
            {
                var userRolesVM = new UserRoleVM
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRolesVM.Selected = true;
                }
                else
                {
                    userRolesVM.Selected = false;
                }
                model.Add(userRolesVM);
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Manage(List<UserRoleVM> model, string userId)
        {
            var user = await userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View();
            }

            var roles = await userManager.GetRolesAsync(user);
            var result = await userManager.RemoveFromRolesAsync(user, roles);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing roles");
                return View(model);
            }
            result = await userManager.AddToRolesAsync(user, model.Where(x => x.Selected).Select(y => y.RoleName));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected roles to user");
                return View(model);
            }

            return RedirectToAction("Index");
        }
    }
}
