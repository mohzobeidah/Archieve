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
        

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string FourthName { get; set; }
        public int  IdentityNumber { get; set; }
        public int FK_JehazId { get; set; }
        [ForeignKey(nameof(FK_JehazId))]
        public virtual WorkPlace WorkPlace { get; set; }
      
        public ICollection<MailArchive> mailArchives{ get; set; }

        public virtual ICollection<MangerDepartment> MangerDepartment { get; set; }

        public string InsertUser { get; set; }
        public DateTime? InsertDate { get; set; } = DateTime.Now;

        public string UpdateUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }


    }
}
