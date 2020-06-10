using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.ViewModel
{
    public class EmployeeVM
    {
        public int EmpId { get; set; }
        public Nullable<int> ID { get; set; }
        public string FinID { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string ThName { get; set; }
        public string LName { get; set; }
        public Nullable<int> FK_WorkPlaceId { get; set; }
        public string InsertUser { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }

    }
}
