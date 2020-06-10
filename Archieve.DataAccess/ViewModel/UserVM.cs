using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Archieve.DataAccess.ViewModel
{
   public class UserVM
    {
        [Required]
        public string Name { get; set; }
        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        //[Required]
        //public string IDCard { get; set; }
        //public string WorkPlace { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}
