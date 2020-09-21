using System;
using System.Collections.Generic;
using System.Text;

namespace Archieve.DataAccess.ViewModel
{
 
    public class UserActivity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Data { get; set; }
        public string UserName { get; set; }
        public string IpAddress { get; set; }
        public DateTime ActivityDate { get; set; } = DateTime.Now;
    }
}
