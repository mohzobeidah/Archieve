using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string InsertUser { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

        //list

        public IEnumerable<SelectListItem> classificationList { get; set; }
        public IEnumerable<SelectListItem> mailTypeList { get; set; }
        public IEnumerable<SelectListItem> postTypeList { get; set; }
        public IEnumerable<SelectListItem> securityList { get; set; }
        public IEnumerable<SelectListItem> statusList { get; set; }

        //  public HttpPostedFileBase file { get; set; }
        public string test { get; set; }

        public string ScannedFiles { get; set; }


    }
}
