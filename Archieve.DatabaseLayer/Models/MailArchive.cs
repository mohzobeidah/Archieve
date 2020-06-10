using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class MailArchive
    {
        public int ID { get; set; }
        public string MailId { get; set; }
        public string Year { get; set; }

        public int FK_FromJehazId { get; set; }
        public Nullable<int> FK_ToJehazId { get; set; }

        [Column(TypeName = "VARCHAR(4000)")]
        public string Topic { get; set; }
        [Column(TypeName = "VARCHAR(4000)")]
        public string Note { get; set; }

        public Nullable<int> FK_ClassificationId { get; set; }
        [ForeignKey(nameof(FK_ClassificationId))]
        public Classification Classification { get; set; }

       
        public int FK_MailTypeId { get; set; }
        [ForeignKey(nameof(FK_MailTypeId))]
        public MailType MailType { get; set; }

        public int FK_SecurityId { get; set; }
        [ForeignKey(nameof(FK_SecurityId))]
        public Security Security { get; set; }

        public int FK_PostTypeId { get; set; }
        [ForeignKey(nameof(FK_PostTypeId))]
        public PostType PostType { get; set; }

        public int FK_StatusId { get; set; }
        [ForeignKey(nameof(FK_StatusId))]
        public Status Status { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        public string InsertUser { get; set; }
        public DateTime? InsertDate { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDelete { get; set; }



        ///  public HttpPostedFileBase file { get; set; }
        public string test { get; set; }

        public string ScannedFiles { get; set; }
    }
}
