using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Core.Aplication.ViewModel.User
{
 public   class Login
    {
            [Required(ErrorMessage = "Debe colocar el nombre de usuario")]
            [DataType(DataType.Text)]
            public string Username { get; set; }

            [Required(ErrorMessage = "Debe colocar una contraseña")]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        
    }
}
