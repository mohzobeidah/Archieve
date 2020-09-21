using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class MilitaryRank: GeneralEntity
    {
        public int Id { get; set; }
        public string RankName { get; set; }
        public ICollection<User> users { get; set; }



    }
}
