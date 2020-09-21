﻿using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DataAccess.ViewModel
{
    public class MilitaryRankVM
    {
        public int Id { get; set; }
        public string RankName { get; set; }
        public ICollection<User> users { get; set; }
        public string InsertUser { get; set; }
        public DateTime? InsertDate { get; set; }
  
        public string UpdateUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
