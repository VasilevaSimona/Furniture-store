using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Domain.Identity
{
    public class UserRegistrationDto
    {
        [EmailAddress(ErrorMessage="Invalid email address")]
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confrim password is required")]
        [Compare("Password", ErrorMessage ="The Password and Confrim Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}

