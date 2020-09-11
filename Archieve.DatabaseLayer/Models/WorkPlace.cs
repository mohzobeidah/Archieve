using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Archieve.DatabaseLayer.Models
{
   public class WorkPlace: GeneralEntity
    {
        [key]
        public int Id { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Text { get; set; }
        public int FK_WpId { get; set; }
        [ForeignKey(nameof(FK_WpId))]
        public virtual StructureType StructureType { get; set; }
     

        
        [InverseProperty("FromJehazId")]
        public ICollection<MailArchive> mailArchivesFrom   { get; set; }

        [InverseProperty("ToJehazId")]
        public ICollection<MailArchive> mailArchivesTo { get; set; }

 
        public ICollection<User> Users { get; set; }

        public virtual ICollection<MangerDepartment> MangerDepartment { get; set; }



    }
}
