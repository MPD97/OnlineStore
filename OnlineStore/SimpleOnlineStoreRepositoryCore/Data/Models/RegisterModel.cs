using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Models
{
    public class RegisterModel
    {
        [Required, Display(Name = "Email Address"), MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "First Name"), MinLength(2), MaxLength(30)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"), MinLength(2), MaxLength(30)]
        public string LastName { get; set; }

        public string Company { get; set; }

        [Required, Display(Name = "Password"), MinLength(4), MaxLength(20)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, Display(Name = "Repeat Password"), MinLength(4), MaxLength(20), Compare("Password")]
        [DataType(DataType.Password)]
        public string RepeatPassword { get; set; }
    }
}
