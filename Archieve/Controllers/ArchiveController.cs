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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Archieve.Controllers
{
    public class ArchiveController : BaseController
    {
        private readonly IMapper mapper;
        private readonly IClassificationService classification;
        private readonly IMailTypeService mailType;
        private readonly IPostTypeService postType;
        private readonly ISecurityService security;
        private readonly IStatusService status;


        
        public ArchiveController(IHttpContextAccessor accessor,
                                 IMapper mapper,
                                 IClassificationService classification,
                                 IMailTypeService mailType,
                                 IPostTypeService postType,
                                 ISecurityService security,
                                 IStatusService status) : base(accessor)
        {

            this.mapper = mapper;
            this.classification = classification;
            this.mailType = mailType;
            this.postType = postType;
            this.security = security;
            this.status = status;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ManageSystem()
        {
            return View();
        }
        public IActionResult getClassification(DataTablesParam param)
        {
            int totalNo = 0, recordFilter = 0;
            var obj = classification.GetClassifications(
                param.sSearch,
                param.iDisplayStart,
                param.iDisplayLength,
                out totalNo,
                out recordFilter
                );
            var newObj=obj.Select(c => new {
                id=c.Id,
                gname = c.ClassificationName
            }) ;
            return Json(new
            {
                data = newObj,
                eEcho = param.sEcho,
                iTotalDisplayRecords = recordFilter,
                iTotalRecords = totalNo
            });
        }
        public IActionResult getMailType(DataTablesParam param)
        {
            int totalNo = 0, recordFilter = 0;
            var obj = mailType.GetMailTypes(
                param.sSearch,
                param.iDisplayStart,
                param.iDisplayLength,
                out totalNo,
                out recordFilter
                );

            var newObj = obj.Select(c => new {
                id = c.Id,
                gname = c.MailName
            });
            return Json(new
            {
                data = newObj,
                eEcho = param.sEcho,
                iTotalDisplayRecords = recordFilter,
                iTotalRecords = totalNo
            });
        }
        public IActionResult getPostType(DataTablesParam param)
        {
            int totalNo = 0, recordFilter = 0;
            var obj = postType.GetPostTypes(
                param.sSearch,
                param.iDisplayStart,
                param.iDisplayLength,
                out totalNo,
                out recordFilter
                );
            var newObj = obj.Select(c => new {
                id = c.Id,
                gname = c.PostName
            });
            return Json(new
            {
                data = newObj,
                eEcho = param.sEcho,
                iTotalDisplayRecords = recordFilter,
                iTotalRecords = totalNo
            });
        }
        public IActionResult getSecurity(DataTablesParam param)
        {
            int totalNo = 0, recordFilter = 0;
            var obj = security.GetSecurities(
                param.sSearch,
                param.iDisplayStart,
                param.iDisplayLength,
                out totalNo,
                out recordFilter
                );
            var newObj = obj.Select(c => new {
                id = c.Id,
                gname = c.SecurityName
            });
            return Json(new
            {
                data = newObj,
                eEcho = param.sEcho,
                iTotalDisplayRecords = recordFilter,
                iTotalRecords = totalNo
            });
        }
        public IActionResult getStatus(DataTablesParam param)
        {
            int totalNo = 0, recordFilter = 0;
            var obj = status.GetStatus(
                param.sSearch,
                param.iDisplayStart,
                param.iDisplayLength,
                out totalNo,
                out recordFilter
                );
            var newObj = obj.Select(c => new {
                id = c.Id,
                gname = c.StatusName
            });
            return Json(new
            {
                data = newObj,
                eEcho = param.sEcho,
                iTotalDisplayRecords = recordFilter,
                iTotalRecords = totalNo
            });
        }
        public IActionResult saveClassification(int id)
        {
            if (id == 0)
            {
                if (ModelState.IsValid)
                {
                    return PartialView("_addClassification");
                }

            }
            else
            {
                if (ModelState.IsValid)
                {
                    var obj = classification.GetQueryable(c => c.Id == id).FirstOrDefault();
                    return PartialView("_addClassification", obj);
                }
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult>  saveClassification(ClassificationVM model)
        {
            if (model.Id == 0)
            {

                //if (ModelState.IsValid)
                //{

                    model.InsertDate = DateTime.UtcNow;
                    model.InsertUser = USERNAME;
                    var newObjectForSave = mapper.Map<Classification>(model);
                    var result = await classification.AddAndLogAsync(newObjectForSave, USERNAME);
                    if (result > 0)
                    {
                        return Json(new
                        {
                            status = JsonStatus.Success,
                            link = "جيد",
                            color = NotificationColor.success.ToString().ToLower(),
                            msg = "تم الحفظ بنجاح",
                            ObjectID = newObjectForSave.Id

                        });
                    }
                    else
                    {

                        return Json(new
                        {
                            status = JsonStatus.Error,
                            link = "يوجد خطا",
                            color = NotificationColor.error.ToString().ToLower(),
                            ObjectID = newObjectForSave.Id,
                            msg = "يوجد خطا في عملية الحفظ",
                        });

                    }
                //}

                //return Json(new
                //{
                //    status = JsonStatus.Error,
                //    link = "",
                //    color = NotificationColor.error.ToString().ToLower(),
                //    msg = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                //                 .Select(m => m.ErrorMessage).ToArray()
                //});
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var getClassifiction = await classification.GetAsync(x => x.Id == model.Id);

                    var firstClassifiction = getClassifiction.FirstOrDefault();
                    firstClassifiction.ClassificationName = model.ClassificationName;
                    firstClassifiction.UpdateUser = USERNAME;
                    firstClassifiction.UpdatedDate = DateTime.UtcNow;



                    var result = await classification.UpdateAndLogAsync(firstClassifiction, USERNAME);
                    if (result > 0)
                    {
                        return Json(new
                        {
                            status = JsonStatus.Success,
                            link = "جيد",
                            color = NotificationColor.success.ToString().ToLower(),
                            msg = "تم الحفظ نجاح",
                            ObjectID = model.Id

                        });
                    }
                    else
                    {

                        return Json(new
                        {
                            status = JsonStatus.Error,
                            link = "يوجد خطا",
                            color = NotificationColor.error.ToString().ToLower(),
                            ObjectID = model.Id,
                            msg = "يوجد خطا في عملية الحفظ",
                        });

                    }

                }
                return Json(new
                {
                    status = JsonStatus.Error,
                    link = "",
                    color = NotificationColor.error.ToString().ToLower(),
                    msg = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                   .Select(m => m.ErrorMessage).ToArray()
                });
            }
        }
        public async Task<JsonResult> deleteClassification(int? id)
        {

            if (id == null)
            {
                return Json(new
                {
                    status = JsonStatus.Error,
                    link = "يوجد خطا",
                    color = NotificationColor.error.ToString().ToLower(),
                    msg = "يوجد خطا تأكد من البيانات",
                });
            }
            var getClassficationDelete = classification.Find(id);
            if (getClassficationDelete.Id > 0)
            {
                getClassficationDelete.IsDeleted = true;
                getClassficationDelete.UpdatedDate = DateTime.UtcNow;
                getClassficationDelete.UpdateUser = USERNAME;
                var result = await classification.UpdateAndLogAsync(getClassficationDelete, USERNAME);
                if (result > 0)
                {
                    return Json(new
                    {
                        status = JsonStatus.Success,
                        link = "جيد",
                        color = NotificationColor.success.ToString().ToLower(),
                        msg = "تم الحذف بنجاح",
                        ObjectID = getClassficationDelete.Id
                    });
                }
                else
                {
                    return Json(new
                    {
                        status = JsonStatus.Error,
                        link = "يوجد خطا",
                        color = NotificationColor.error.ToString().ToLower(),
                        ObjectID = getClassficationDelete.Id,
                        msg = "يوجد خطا في عملية الحذف",
                    });
                }
            }
            return Json(new
            {
                status = JsonStatus.Error,
                link = "",
                color = NotificationColor.error.ToString().ToLower(),
                msg = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                            .Select(m => m.ErrorMessage).ToArray()
            });
        }

    }
}
