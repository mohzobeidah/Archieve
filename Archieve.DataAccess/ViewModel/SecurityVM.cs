using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.ViewModel
{
    public class SecurityVM
    {
        public int Id { get; set; }
        public string SecurityName { get; set; }

        public ICollection<Security> security { get; set; }

        public string InsertUser { get; set; }
        public DateTime? InsertDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDelete { get; set; }

    }
}
