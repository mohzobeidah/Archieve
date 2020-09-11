using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archieve.DatabaseLayer.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Archieve.DataAccess.ViewModel
{
    public class MailArchiveVM
    {
        public int ID { get; set; }
        public string MailId { get; set; }
        public string Year { get; set; }
        public int FK_FromJehazId { get; set; }
        public int FK_ToJehazId { get; set; }
        public string Topic { get; set; }
        public int FK_ClassificationId { get; set; }
        public int FK_MailTypeId { get; set; }
        public int FK_SecurityId { get; set; }
        public int FK_PostTypeId { get; set; }
        public int FK_StatusId { get; set; }
        public string Note { get; set; }
        public DateTime? ArchiveDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Date")]
        public string InsertUser { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeletedd { get; set; }

        //list

        public IEnumerable<SelectListItem> classificationList { get; set; }
        public IEnumerable<SelectListItem> mailTypeList { get; set; }
        public IEnumerable<SelectListItem> postTypeList { get; set; }
        public IEnumerable<SelectListItem> securityList { get; set; }
        public IEnumerable<SelectListItem> statusList { get; set; }
        public IEnumerable<SelectListItem> fromJehazList { get; set; }
        public IEnumerable<SelectListItem> toJehazList { get; set; }
        //  public HttpPostedFileBase file { get; set; }
        public string test { get; set; }

        public string ScannedFiles { get; set; }
        public ICollection<ImageArchive> imageArchives { get; set; }

    }
    
}
