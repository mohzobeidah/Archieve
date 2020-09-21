using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archieve.DataAccess.IRepository;
using Archieve.DatabaseLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Archieve.Controllers
{
    public class BaseController : Controller
    {
        private readonly IHttpContextAccessor _accessor;
        private readonly IUserService userService;
              public static string USERNAME = USERNAME;
        protected string IpAddresss;

        public BaseController(IHttpContextAccessor accessor, IUserService userService)
        {
            _accessor = accessor;
            this.userService = userService;
            checkUser();

        }
        public void checkUser()
        {
            if (_accessor.HttpContext.User.Identity.IsAuthenticated)
            {
                USERNAME = _accessor.HttpContext.User.Identity.Name;
                IpAddresss = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            }
        }
        public User USER_NAME  
        { 
            get 
            { 
                return userService.getUserByUserName(_accessor.HttpContext.User.Identity.Name); 
            } 
        }

    }
}
