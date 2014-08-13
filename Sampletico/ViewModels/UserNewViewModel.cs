using Sampletico.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sampletico.ViewModels
{
    public class UserNewViewModel
    {
        [Required]
        [UniqueEmail]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [Display(Name="Retype password")]
        public string PasswordConfirmation { get; set; }

        public bool IsAdmin { get; set; }

    }
}