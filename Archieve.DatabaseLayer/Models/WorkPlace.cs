using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Archieve.DatabaseLayer.Models
{
   public class WorkPlace
    {
        public int Id { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Text { get; set; }
        public int FK_WpId { get; set; }
        [ForeignKey(nameof(FK_WpId))]
        public virtual StructureType StructureType { get; set; }
        public string InsertUser { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

        public ICollection<MailArchive> mailArchives   { get; set; }

        public ICollection<MailArchive> mailArchivesto { get; set; }


    }
}
