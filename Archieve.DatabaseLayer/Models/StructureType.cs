using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Archieve.DatabaseLayer.Models
{
   public class StructureType: GeneralEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
   
        public ICollection<WorkPlace> workPlaces { get; set; }
    }
    
}
