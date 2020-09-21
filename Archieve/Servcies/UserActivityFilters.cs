using Archieve.DataAccess.DataConfigration;
using Archieve.DataAccess.ViewModel;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Archieve.Servcies
{
    public class UserActivityFilters : IActionFilter
    {
        private readonly DataContext context;

        public UserActivityFilters(DataContext context)
        {
            this.context = context;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var data = "";
            var controllerName = context.RouteData.Values["controller"];
            var actionName = context.RouteData.Values["action"];
            var Url = $"{controllerName}/{actionName}";

            if (!string.IsNullOrEmpty(context.HttpContext.Request.QueryString.Value)) 
            {
                data = context.HttpContext.Request.QueryString.Value;
            }
            else
            {
               var userData= context.ActionArguments.FirstOrDefault();
                var stringUserData = JsonConvert.SerializeObject(userData);
            }
            var userName = context.HttpContext.User.Identity.Name;
            var ipAddress = context.HttpContext.Connection.RemoteIpAddress.ToString();
             var userClaims = context.HttpContext.User.Claims.ToList();
            storeUserActivity(data, Url, userName, ipAddress);
        }
        public void storeUserActivity(string data,string url,string userName,string ipAddress)
        {
            var userActivity = new UserActivity { 
            Data=data,
            Url=url,
            UserName=userName,
            IpAddress=ipAddress
            };
            context.UserActivities.Add(userActivity);
            context.SaveChanges();
        }
    } 
}
