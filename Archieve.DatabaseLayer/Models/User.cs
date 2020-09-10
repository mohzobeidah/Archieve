using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Archieve.DatabaseLayer.Models
{
    public class User:IdentityUser
    {
        //public int FK_FromJehazId { get; set; }
        //[ForeignKey(nameof(FK_FromJehazId))]
        //public virtual WorkPlace FromJehazId { get; set; }
        //public int FK_ToJehazId { get; set; }
        //[ForeignKey(nameof(FK_ToJehazId))]
        //public virtual WorkPlace ToJehazId { get; set; }
        //[Key]
        //public string ID { get; set; }
        //public string IDCard { get; set; }
        //public string WorkPlace { get; set; }

        public int FK_JehazId { get; set; }
        [ForeignKey(nameof(FK_JehazId))]
        public virtual WorkPlace WorkPlace { get; set; }
      
        public ICollection<MailArchive> mailArchives{ get; set; }


    }
}
