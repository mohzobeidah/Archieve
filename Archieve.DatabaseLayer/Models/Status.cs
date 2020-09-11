﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archieve.DatabaseLayer.Models
{
    public class Status: GeneralEntity
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public ICollection<MailArchive> mailArchives { get; set; }



    }
}
