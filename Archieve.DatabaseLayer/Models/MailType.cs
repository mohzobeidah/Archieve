using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class MailType
    {
        public int Id { get; set; }
        public string MailName { get; set; }
        public ICollection<MailType> mailTypes { get; set; }

        [Column(TypeName = "VARCHAR(250)")]
        public string InsertUser { get; set; }
        public DateTime? InsertDate { get; set; }
        [Column(TypeName = "VARCHAR(250)")]
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
