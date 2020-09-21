using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Archieve.DataAccess.ViewModel
{
   public class UserVM
    {
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required] 
        public string ThirdName { get; set; }
        [Required]
        public string FourthName { get; set; }

        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        public int FK_JehazId { get; set; }
        public int IdentityNumber { get; set; }
        public int FinanceNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int FK_MilitaryRankId { get; set; }


        //[Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public IEnumerable<SelectListItem> JehazList { get; set; }
        public IEnumerable<SelectListItem> MilitaryRankList { get; set; }
    }
}
