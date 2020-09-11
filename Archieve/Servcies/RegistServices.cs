using Archieve.DataAccess.IRepository;
using Archieve.DataAccess.Repository;
using Archieve.DatabaseLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Archieve.Servcies
{
    public static class RegistServices
    {
        public static void AddRepositoryServcies(this IServiceCollection services)
            {

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IClassificationService, ClassificationService>();
            services.AddScoped<IPostTypeService, PostTypeService>();
            services.AddScoped<IMailTypeService, MailTypeService>();
            services.AddScoped<ISecurityService, SecurityService>();
            services.AddScoped<IStatusService, StatusService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IWorkPlaceService, WorkPlaceService>();
            services.AddScoped<IMailArchiveService, MailArchiveService>(); 
            services.AddScoped<IImageArchiveService, ImageArchiveService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
