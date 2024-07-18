using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersCrudWithCShard_MVC.DTOs
{
    public class UserInsertDto
    {
        
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "El nombre debe de longitud entre 3 a 25 caracteres")]
        public string firstName { get; set; }

        [DisplayName("Apellido")]
        [Required(ErrorMessage = "El apellido es requerido.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "El apellido debe de longitud entre 3 a 25 caracteres")]
        public string lastName { get; set; }

        [DisplayName("Nombre de usuario")]
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El nombre de usuario debe de longitud entre 3 a 20 caracteres")]
        public string userName { get; set; }

        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "La contraseña es requerida.")]
        public string password { get; set; }

        [DisplayName("Correo Electronico")]
        [Required(ErrorMessage = "El correo electronico es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El correo electronico debe de longitud entre 3 a 50 caracteres")]
        public string email { get; set; }

    }
}
