using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Archieve.DataAccess.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Archieve.Controllers
{
    public class StructureController : BaseController
    {
        private readonly IMapper mapper;
        private readonly IWorkPlaceService workPlaceService;

        //private readonly IClassificationService classification;
        //private readonly IMailTypeService mailType;
        //private readonly IPostTypeService postType;
        //private readonly ISecurityService security;
        //private readonly IStatusService status;



        public StructureController(IHttpContextAccessor accessor,
                                 IMapper mapper,
                                 IWorkPlaceService workPlaceService
                                 //IClassificationService classification,
                                 //IMailTypeService mailType,
                                 //IPostTypeService postType,
                                 //ISecurityService security,
                                 //IStatusService status
            ) : base(accessor)
        {

            this.mapper = mapper;
            this.workPlaceService = workPlaceService;
            //this.classification = classification;
            //this.mailType = mailType;
            //this.postType = postType;
            //this.security = security;
            //this.status = status;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Structures()
        {
            //var tree = workPlaceService.GetWorkPlaces(null);
            return View();
        }
        public JsonResult StructuresAjax()
        {
           var tree = workPlaceService.GetWorkPlaces(null);
           return Json(tree);
        }
    }
}
