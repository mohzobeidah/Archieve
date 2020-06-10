using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.ViewModel
{
   public class WorkPlaceVM
    {
        public int Id { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string Text { get; set; }
        public int FK_WpId { get; set; }
        public virtual StructureType StructureType { get; set; }
        public string InsertUser { get; set; }
        public Nullable<System.DateTime> InsertDate { get; set; }
        public string UpdatedUser { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
