using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.ViewModel
{
    public class ImageArchiveVM
    {
        public int Id { get; set; }
        public string FK_MailArchiveID { get; set; }
        public byte[] ContentMail { get; set; }
        public string Name { get; set; }
        public Nullable<int> Size { get; set; }
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
