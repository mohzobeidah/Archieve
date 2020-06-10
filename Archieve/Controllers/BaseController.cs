using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Archieve.Controllers
{
    public class BaseController : Controller
    {
        private readonly IHttpContextAccessor _accessor;

        protected  string USERNAME ="IBaik ";
        protected string IpAddresss;

        public BaseController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
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
    }
}
