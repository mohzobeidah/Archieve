using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class Security
    {
        public int Id { get; set; }
        public string SecurityName { get; set; }

        public ICollection<MailArchive> mailArchives { get; set; }


        public string InsertUser { get; set; }
        public DateTime? InsertDate { get; set; }
     
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDelete { get; set; }

    }
}
