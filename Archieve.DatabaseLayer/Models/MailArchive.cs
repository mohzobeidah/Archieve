using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class MailArchive: GeneralEntity
    {
        public int ID { get; set; }
        public string MailId { get; set; }
        public string Year { get; set; }


        public int? FK_FromJehazId { get; set; }
        
        [ForeignKey(nameof(FK_FromJehazId))]
        public virtual WorkPlace FromJehazId { get; set; }


        public int? FK_ToJehazId { get; set; }
   
        [ForeignKey(nameof(FK_ToJehazId))]
        public virtual WorkPlace ToJehazId { get; set; }

        public string Topic { get; set; }
     
        public string Note { get; set; }

        public DateTime? ArchiveDate { get; set; }
        public Nullable<int> FK_ClassificationId { get; set; }
        [ForeignKey(nameof(FK_ClassificationId))]
        public Classification Classification { get; set; }

       
        public int? FK_MailTypeId { get; set; }
        [ForeignKey(nameof(FK_MailTypeId))]
        public MailType MailType { get; set; }

        public int? FK_SecurityId { get; set; }
        [ForeignKey(nameof(FK_SecurityId))]
        public Security Security { get; set; }
     
        public int FK_PostTypeId { get; set; }
        [ForeignKey(nameof(FK_PostTypeId))]
        public PostType PostType { get; set; }

        public int FK_StatusId { get; set; }
        [ForeignKey(nameof(FK_StatusId))]
        public Status Status { get; set; }



        public string FK_User { get; set; }
        [ForeignKey(nameof(FK_User))]
        public virtual User user { get; set; }

        public int UserWorkPlaceID { get; set; }
        [ForeignKey(nameof(UserWorkPlaceID))]
        public WorkPlace UserWorkPlace { get; set; }

        public ICollection<ImageArchive> imageArchives { get; set; }
        /// public string ScannedFiles { get; set; }
    }
}
