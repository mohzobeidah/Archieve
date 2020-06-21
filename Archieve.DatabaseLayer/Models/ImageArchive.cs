using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class ImageArchive
    {
        public int Id { get; set; }

        public int  FK_MailArchiveID { get; set; }
        [ForeignKey(nameof(FK_MailArchiveID))]
        public virtual MailArchive  MailArchive { get; set; }

        public byte[] ContentMail { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }
        public string InsertUser { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

    }
}
