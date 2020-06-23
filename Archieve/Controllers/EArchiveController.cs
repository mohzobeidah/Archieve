﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Archieve.DataAccess.Enum;
using Archieve.DataAccess.IRepository;
using Archieve.DataAccess.Repository;
using Archieve.DataAccess.ViewModel;
using Archieve.DatabaseLayer.Models;
using Archieve.Helper;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace Archieve.Controllers
{
    [EnableCors("MyAllowSpecificOrigins")]

    public class EArchiveController : BaseController
    {
        private readonly IHttpContextAccessor accessor;
        private readonly IMapper mapper;
        private readonly IMailArchiveService mailArchiveService;
        private readonly IWorkPlaceService workPlaceService;
        private readonly IClassificationService classificationService;
        private readonly IMailTypeService mailTypeService;
        private readonly IPostTypeService postTypeService;
        private readonly ISecurityService securityService;
        private readonly IStatusService statusService;
        //private readonly ILogger logger;

        public EArchiveController(IHttpContextAccessor accessor,
                                 IMapper mapper,
                                 IMailArchiveService mailArchiveService,
                                 IWorkPlaceService workPlaceService,
                                 IClassificationService classificationService,
                                 IMailTypeService mailTypeService,
                                 IPostTypeService postTypeService,
                                 ISecurityService securityService,
                                 IStatusService statusService
                                 //ILogger logger
            ) : base(accessor)
        {
            this.accessor = accessor;
            this.mapper = mapper;
            this.mailArchiveService = mailArchiveService;
            this.workPlaceService = workPlaceService;
            this.classificationService = classificationService;
            this.mailTypeService = mailTypeService;
            this.postTypeService = postTypeService;
            this.securityService = securityService;
            this.statusService = statusService;
            //this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult getMailArchive(DataTablesParam param)
        {
            int totalNo = 0, recordFilter = 0;
            var obj = mailArchiveService.GetMailArchives(
                param.sSearch,
                param.iDisplayStart,
                param.iDisplayLength,
                out totalNo,
                out recordFilter
                );
            var newObj = obj.Select(m => new {

                id = m.ID,
                mailId=m.MailId,
                mailType = m.MailType.MailName,
                postType = m.PostType.PostName,
              //  classificationType = m.Classification.ClassificationName,
                insertdate = m.InsertDate.Value.ToString("dd/MM/yyy")?? DateTime.Now.AddYears(-40).ToString("dd/MM/yyy"),
                fromJehaz = m.FK_FromJehazId,
                toJehaz = m.FK_ToJehazId,
                topic=m.Topic.ToString().Substring(0, 50)+"....."
            });
            return Json(new
            {
                data = newObj,
                eEcho = param.sEcho,
                iTotalDisplayRecords = recordFilter,
                iTotalRecords = totalNo
            });  
        }

        public void getAllList()
        {
            ViewBag.classificationList = classificationService.GetQueryable(c => c.IsDelete == false).GetListItems("ClassificationName", "Id", 0).ToList();
            ViewBag.mailTypeList = mailTypeService.GetQueryable(c => c.IsDelete == false).GetListItems("MailName", "Id", 0).ToList();
            ViewBag.postTypeList = postTypeService.GetQueryable(c => c.IsDelete == false).GetListItems("PostName", "Id", 0).ToList();
            ViewBag.securityList = securityService.GetQueryable(c => c.IsDelete == false).GetListItems("SecurityName", "Id", 0).ToList();
            ViewBag.statusList = statusService.GetQueryable(c => c.IsDelete == false).GetListItems("StatusName", "Id", 0).ToList();
        }
       [EnableCors("MyAllowSpecificOrigins")]
        public async Task<IActionResult> saveArchive(int id)
        {
            if (id==0)
            {
                var eArchive = new MailArchiveVM();

                eArchive.classificationList = classificationService.GetQueryable(c => c.IsDelete == false).GetListItems("ClassificationName", "Id", 0).ToList();
                eArchive.mailTypeList =  mailTypeService.GetQueryable(c => c.IsDelete == false).GetListItems("MailName", "Id", 0).ToList();
                eArchive.postTypeList = postTypeService.GetQueryable(c => c.IsDelete == false).GetListItems("PostName", "Id", 0).ToList();
                eArchive.securityList = securityService.GetQueryable(c => c.IsDelete == false).GetListItems("SecurityName", "Id", 0).ToList();
                eArchive.statusList = statusService.GetQueryable(c => c.IsDelete == false).GetListItems("StatusName", "Id", 0).ToList();

                return View(eArchive);
            }
            else
            {
              var getMailArchive = mailArchiveService.getMailArchiveById(id);
                var mailArchive = getMailArchive.FirstOrDefault();
                var mailArchivevm = mapper.Map<MailArchiveVM>(mailArchive);

                mailArchivevm.classificationList = await classificationService.GetQueryable(c => c.IsDelete == false).Select(x => new SelectListItem
                {
                    Text = x.ClassificationName,
                    Value = x.Id.ToString()
                }).ToListAsync();
                mailArchivevm.mailTypeList = await mailTypeService.GetQueryable(c => c.IsDelete == false)
                                                .Select(x => new SelectListItem
                                                {
                                                    Text = x.MailName,
                                                    Value = x.Id.ToString()
                                                }).ToListAsync();
                mailArchivevm.postTypeList = postTypeService.GetQueryable(c => c.IsDelete == false).GetListItems("PostName","Id",0).ToList();
                mailArchivevm.securityList = securityService.GetQueryable(c => c.IsDelete == false).GetListItems("SecurityName", "Id", 0).ToList();
                mailArchivevm.statusList = statusService.GetQueryable(c => c.IsDelete == false).GetListItems("StatusName", "Id", 0).ToList();


                return View(mailArchivevm);
            }
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<JsonResult> saveArchive(MailArchiveVM model)
        {
            var eArchive = new MailArchiveVM {

                classificationList = classificationService.GetQueryable(c => c.IsDelete == false).GetListItems("ClassificationName", "Id", 0).ToList(),
            mailTypeList = mailTypeService.GetQueryable(c => c.IsDelete == false).GetListItems("MailName", "Id", 0).ToList(),
            postTypeList = postTypeService.GetQueryable(c => c.IsDelete == false).GetListItems("PostName", "Id", 0).ToList(),
            securityList = securityService.GetQueryable(c => c.IsDelete == false).GetListItems("SecurityName", "Id", 0).ToList(),
            statusList = statusService.GetQueryable(c => c.IsDelete == false).GetListItems("StatusName", "Id", 0).ToList(),
              };
            //model.FK_StatusId = 2; /// هذي انت انسيتها في الفيو

            if (model.ID == 0)
            {
               
                if (ModelState.IsValid)
                {
                    model.InsertDate = DateTime.UtcNow;
                    model.InsertUser = USERNAME;
                    var newModel = mapper.Map<MailArchive>(model);

                    //try
                    //{

                        var getByteForFiles = GetStream(model.ScannedFiles.Split(','));

                        ImageArchive imageArchiveVM = new ImageArchive
                        {
                            Id = 0,
                            Name = $"{ Guid.NewGuid().ToString()}.PDF",
                            ContentMail = getByteForFiles,
                            Extension=".PDF",
                            Type= "application/pdf"
                        };

                        // var sssss = ImageArchiveRepositry.Add(imageArchiveVM);

                        // System.IO.File.WriteAllBytes(@"E:\hello.pdf", sssss.ContentMail);
                      
                        newModel.imageArchives = new List<ImageArchive> { imageArchiveVM };


                        var result = await mailArchiveService.AddAndLogAsync(newModel, USERNAME);

                        if (result > 0)
                        {
                            return Json(new
                            {
                                status = JsonStatus.Success,
                                link = "جيد",
                                color = NotificationColor.success.ToString().ToLower(),
                                msg = "تم الحفظ بنجاح",
                                ObjectID = newModel.ID

                            });
                        }
                        else
                        {
                            return Json(new
                            {
                                status = JsonStatus.Error,
                                link = "يوجد خطا",
                                color = NotificationColor.error.ToString().ToLower(),
                                msg = "يوجد خطا في عملية الحفظ",
                                ObjectID = newModel.ID,
                            });
                        }

                    //}
                    //catch (Exception)
                    //{

                    //    return Json(new
                    //    {
                    //        status = JsonStatus.Error,
                    //        link = "يوجد خطا",
                    //        color = NotificationColor.error.ToString().ToLower(),
                    //        msg = "يوجد خطا في عملية الحفظ",
                    //        ObjectID = newModel.ID,
                    //    });
                    //    throw;
                    //}

                  
                  
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
            else
            {
                if (ModelState.IsValid)
                {

                    var getMailArchiveById = await mailArchiveService.GetAsync(m => m.ID == model.ID);
                    var firstMailArchive= getMailArchiveById.FirstOrDefault();

                    firstMailArchive.FK_MailTypeId = model.FK_MailTypeId;
                    firstMailArchive.FK_ClassificationId = model.FK_ClassificationId;
                    firstMailArchive.FK_PostTypeId = model.FK_PostTypeId;
                    firstMailArchive.FK_SecurityId = model.FK_SecurityId;
                    firstMailArchive.FK_StatusId = model.FK_StatusId;
                    firstMailArchive.FK_FromJehazId = model.FK_FromJehazId;
                    firstMailArchive.FK_ToJehazId = model.FK_ToJehazId;
                    firstMailArchive.Topic = model.Topic;
                    firstMailArchive.Note = model.Note;
                    firstMailArchive.UpdateDate = DateTime.UtcNow;
                    firstMailArchive.UpdateUser = USERNAME;

                    var result = await mailArchiveService.UpdateAndLogAsync(firstMailArchive, USERNAME);
                    if (result > 0)
                    {
                        return Json(new
                        {
                            status = JsonStatus.Success,
                            link = "جيد",
                            color = NotificationColor.success.ToString().ToLower(),
                            msg = "تم الحفظ بنجاح",
                            ObjectID = firstMailArchive.ID
                        });
                    }
                    else
                    {
                        return Json(new
                        {
                            status = JsonStatus.Error,
                            link = "يوجد خطا",
                            color = NotificationColor.error.ToString().ToLower(),
                            msg = "يوجد خطا في عملية الحفظ",
                            ObjectID = firstMailArchive.ID,
                        });
                    }

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

        private static byte[] GetStream(string[] imageUrl)
        {
            List<Stream> stream = new List<Stream>();
           // byte[] myData = null;
            try
            {

                using (var document = new PdfDocument())
                {
                    for (var i = 0; i < imageUrl.Length; i++)
                    {

                        System.Net.HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(imageUrl[i]);
                        webRequest.AllowWriteStreamBuffering = true;
                        webRequest.Timeout = 30000;

                        System.Net.WebResponse webResponse = webRequest.GetResponse();

                        using (var stream2 = (Stream)webResponse.GetResponseStream())
                        {
                            PdfPage page = document.AddPage();


                            using (XImage img = XImage.FromStream(() => stream2))
                            {

                                // Calculate new height to keep image ratio
                                var height = (int)(((double)600 / (double)img.PixelWidth) * img.PixelHeight);

                                // Change PDF Page size to match image
                                page.Width = 600;
                                page.Height = height;

                                XGraphics gfx = XGraphics.FromPdfPage(page);
                                gfx.DrawImage(img, 0, 0, 600, height);

                                //myData = ReadFully(stream)
                                //  image = System.Drawing.Image.FromStream(stream);

                            }
                        }
                        webResponse.Close();
                    }
                    byte[] docBytes;
                    using (MemoryStream stream3 = new MemoryStream())
                    {
                        // Saves the document as stream
                        document.Save(stream3);
                        document.Close();
                        // Converts the PdfDocument object to byte form.
                        docBytes = stream3.ToArray();
                    }

                    return docBytes;

                }
                //  PdfHelper.SaveImageAsPdf(stream, @"E:\ffffi.pdf");
            }
            catch (Exception ex)
            {
                return null;
            }



        }

    }
}
