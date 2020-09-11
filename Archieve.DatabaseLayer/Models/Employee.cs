using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class Employee: GeneralEntity
    {
        [Key]
        public int EmpId { get; set; }
        public Nullable<int> ID { get; set; }
        public string FinID { get; set; }
   
        public string FName { get; set; }
    
        public string SName { get; set; }
        
        public string ThName { get; set; }
      
        public string LName { get; set; }
        //public Nullable<int> FK_WorkPlaceId { get; set; }
      
        

      //  public ICollection<User> Users { get; set; }


    }
}
