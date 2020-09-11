using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class MangerDepartment: GeneralEntity
    {


        public int Id { get; set; }
        public string UserId { get; set; }
        
        public int WorkPlaceId { get; set; }


        public virtual WorkPlace WorkPlace { get; set; }
        public virtual User User { get; set; }

    }
}
