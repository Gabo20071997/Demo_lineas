using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_lineas.Shared
{
    public  class UserRegister
    {

        [Required, EmailAddress]


        public string Email { get; set; } = String.Empty;
        [Required, StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = String.Empty;
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmPassword { get; set; } = String.Empty;
    }
}
