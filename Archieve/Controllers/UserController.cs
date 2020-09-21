using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archieve.DataAccess.IRepository;
using Archieve.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Archieve.Controllers
{

    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetUser(DataTablesParam param)
        {
            int totalNo = 0, recordFilter = 0;
            var userList = userService.GetUser(param.sSearch, param.iDisplayStart, param.iDisplayLength, out totalNo, out recordFilter);

            var obj = userList.Select(s => new
            {
                id = s.Id,
                fromjehaz = s.WorkPlace.Text,
                militaryRank = s.MilitaryRank.RankName,
                fullName = s.FirstName + ' ' + s.SecondName + ' ' + s.ThirdName + ' ' + s.FourthName,
                userName = s.UserName,
                identityNumber = s.IdentityNumber,
                phoneNumber = s.PhoneNumber,
                financeNumber = s.FinanceNumber


            });
            return Json(
                new
                {
                    data = obj,
                    eEcho = param.sEcho,
                    iTotalDisplayRecords = recordFilter,
                    iTotalRecords = totalNo
                });
        }

    }
}