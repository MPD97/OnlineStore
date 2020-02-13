using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SimpleOnlineStoreRepositoryCore.Data.Models
{
    public class RegisterModel
    {
        [Required, MinLength(2), MaxLength(30)]
        public string FirstName { get; set; }
        [Required, MinLength(2), MaxLength(30)]
        public string LastName { get; set; }
        public string Company { get; set; }
        [Required, MinLength(4), MaxLength(20)]

        public string Password { get; set; }
        [Required, MinLength(4), MaxLength(20), Compare("Password")]

        public string RePassword { get; set; }
    }
}
