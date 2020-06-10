using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Archieve.DatabaseLayer.Models
{
   public class StructureType
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string InsertUser { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public ICollection<WorkPlace> workPlaces { get; set; }
    }
    
}
