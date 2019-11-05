using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAndamios.Areas.Usuarios.Models
{
    public class UsuariosModel
    {
        [Required(ErrorMessage = "Es necesario el nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es necesario el Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "Es necesario el Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Es necesario suministrar una contraseña válida")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "La contraseñas suministradas no coinciden, vuelva a intentarlo.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Es necesario un usuario")]
        public string UserName { get; set; }

        public string Role { get; set; }

        public string Imagen { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Es necesario el Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Es necesaria la contraseña")]
        public string Password { get; set; }
    }
}

