using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DatabaseLayer.Models
{
   public class GeneralEntity
    {
        public string InsertUser { get; set; }
        public DateTime? InsertDate { get; set; }  = DateTime.Now;

        public string UpdateUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
