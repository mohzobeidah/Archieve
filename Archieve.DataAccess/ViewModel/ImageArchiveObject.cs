using Archieve.DatabaseLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.ViewModel
{
   public class ImageArchiveObject
    {
        public MailArchive MailArchive { get; set; }
        public List<ImageNew> imageArchiveVMs { get; set; }
    }
    public class ImageNew   
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
