using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public Nullable<int> ID { get; set; }
        public string FinID { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string FName { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string SName { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string ThName { get; set; }
        [Column(TypeName = "VARCHAR(200)")]
        public string LName { get; set; }
        //public Nullable<int> FK_WorkPlaceId { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string InsertUser { get; set; }
        public DateTime? InsertDate { get; set; }
        [Column(TypeName = "VARCHAR(250)")]

        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDelete { get; set; }

      //  public ICollection<User> Users { get; set; }


    }
}
