﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class Classification
    {
        public int Id { get; set; }
      
        public string ClassificationName { get; set; }
        public ICollection<MailArchive> mailArchives { get; set; }
      
        public string InsertUser { get; set; }
        public DateTime? InsertDate { get; set; }
     
        public string UpdateUser { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
