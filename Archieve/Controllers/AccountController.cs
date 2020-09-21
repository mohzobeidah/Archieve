using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archieve.DataAccess.Enum;
using Archieve.DataAccess.IRepository;
using Archieve.DataAccess.ViewModel;
using Archieve.DatabaseLayer.Models;
using Archieve.Helper;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Archieve.Controllers
{

    public class AccountController : Controller
    {
        private readonly IHttpContextAccessor accessor;
        private readonly IMapper mapper;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IWorkPlaceService workPlaceService;
        private readonly IMilitaryRankService militaryRankService;
        private readonly IUserService userService;

        public AccountController(
                                  IHttpContextAccessor accessor,
                                  IMapper mapper,
                                  RoleManager<IdentityRole> roleManager,
                                  UserManager<User> userManager, 
                                  SignInManager<User> signInManager,
                                  IWorkPlaceService workPlaceService,
                                  IMilitaryRankService militaryRankService,
                                  IUserService userService
                                )
        {
            this.accessor = accessor;
            this.mapper = mapper;
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.workPlaceService = workPlaceService;
            this.militaryRankService = militaryRankService;
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                var userVM = new UserVM();

                userVM.JehazList = workPlaceService.GetQueryable(c => c.IsDeleted == false).GetListItems("Text", "Id", 0).ToList();
                userVM.MilitaryRankList = militaryRankService.GetQueryable(c => c.IsDeleted == false).GetListItems("RankName", "Id", 0).ToList();
                return View(userVM);
            }
            else
            {
                var user = userService.getUserById(id);
                var uservm = mapper.Map<UserVM>(user);

                uservm.JehazList = workPlaceService.GetQueryable(c => c.IsDeleted == false).GetListItems("Text", "Id", 0).ToList();
                uservm.MilitaryRankList = militaryRankService.GetQueryable(c => c.IsDeleted == false).GetListItems("RankName", "Id", 0).ToList();

                return View(uservm);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserVM model ,string returnUrl)
        {
            var dataList = new UserVM
            {
                JehazList = workPlaceService.GetQueryable(c => c.IsDeleted == false).GetListItems("Text", "Id", 0).ToList(),
                MilitaryRankList = militaryRankService.GetQueryable(c => c.IsDeleted == false).GetListItems("RankName", "Id", 0).ToList(),

            };
            if (string.IsNullOrEmpty(model.Id))
            {
                if (ModelState.IsValid)
                {
                    var user = new User
                    {
                        UserName = model.UserName,
                        FirstName = model.FirstName,
                        SecondName = model.SecondName,
                        ThirdName = model.ThirdName,
                        FourthName = model.FourthName,
                        IdentityNumber = model.IdentityNumber,
                        FinanceNumber = model.FinanceNumber,
                        FK_MilitaryRankId = model.FK_MilitaryRankId,
                        PhoneNumber = model.PhoneNumber,
                        FK_JehazId = model.FK_JehazId,
                    };
                    var result = await userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        // var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                        return Json(new
                        {
                            status = JsonStatus.Success,
                            link = "Success",
                            color = NotificationColor.error.ToString().ToLower(),
                            msg = "تم الحفظ بنجاح "
                        });
                        //  return View();
                    }
                    else
                    {
                        return Json(new
                        {
                            status = JsonStatus.Error,
                            link = "تنبيه",
                            color = NotificationColor.error.ToString().ToLower(),
                            msg = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                  .Select(m => m.ErrorMessage).ToArray(),
                        });
                        //     return View(new UserVM());
                    }

                }
                return Json(new
                {
                    status = JsonStatus.Error,
                    link = "تنبيه",
                    color = NotificationColor.error.ToString().ToLower(),
                    msg = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                  .Select(m => m.ErrorMessage).ToArray(),
                });
                //     return View(new UserVM());


            }
            else
            {
                if (ModelState.IsValid)
                {
                    var user = userService.getUserById(model.Id);
                    //   var uservm = mapper.Map<UserVM>(user);
                    user.FirstName = model.FirstName;
                    user.SecondName = model.SecondName;
                    user.ThirdName = model.ThirdName;
                    user.FourthName = model.FourthName;
                    user.IdentityNumber = model.IdentityNumber;
                    user.PhoneNumber = model.PhoneNumber;
                    user.FinanceNumber = model.FinanceNumber;
                    user.FirstName = model.FirstName;
                    user.FK_JehazId = model.FK_JehazId;
                    user.FK_MilitaryRankId = model.FK_MilitaryRankId;
                    user.UpdatedDate = DateTime.UtcNow;
                    //  user.UpdateUser=
                    var result = await userService.UpdateAsync(user);

                    if (result > 0)
                    {
                        return Json(new
                        {
                            status = JsonStatus.Success,
                            link = "Success",
                            color = NotificationColor.success.ToString().ToLower(),
                            msg = "تم الحفظ بنجاح",
                            userId = user.Id
                        });
                    }
                    else
                    { 
                        return Json(new
                        {

                            status = 1,
                            link = "يوجد خطأ",
                            //color = NotificationColor.success.ToString().ToLower(),
                            msg = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                  .Select(m => m.ErrorMessage).ToArray(),
                            userId = user.Id

                        });
                }
                }
                else
                {
                    return Json(new
                    {
                        status = 0,
                        link = "تنبيه",
                        //color = NotificationColor.error.ToString().ToLower(),
                        msg = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                  .Select(m => m.ErrorMessage).ToArray()
                    });
                    //     return View(new UserVM());
                }

            }
          
          
        }
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
              //   var userWorkPlace=await userManager.Users.()
               var user = await userManager.FindByNameAsync(model.UserName);
              
               var result =  await signInManager.PasswordSignInAsync(user, model.Password, 
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

        public async Task<IActionResult> Logout()
        {
          await signInManager.SignOutAsync();
          return  RedirectToAction(nameof(Login));
        }
        public IActionResult AccessDenied()

        {
            //_logger.LogInformation("User AccessDenied .");
            return View();
        }

    }
}
