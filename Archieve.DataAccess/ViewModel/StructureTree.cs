using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Archieve.DataAccess.ViewModel
{
   public class StructureTree
    {
        public string id { get; set; }
        public string parent { get; set; }

        [Required(ErrorMessage = "العنصر مطلوب")]
        public string text { get; set; }
        public string icon { get; set; }
        public string state { get; set; }
        public bool opened { get; set; }
        public bool disabled { get; set; }
        public bool selected { get; set; }
        public string li_attr { get; set; }
        public string a_attr { get; set; }
        public string DepType { set; get; }
        public bool? IsDeletedd { get; set; }

    }
}
