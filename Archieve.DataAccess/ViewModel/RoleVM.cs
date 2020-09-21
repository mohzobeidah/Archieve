using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Archieve.DataAccess.ViewModel
{
    public class RoleVM
    {
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }

    }
}
