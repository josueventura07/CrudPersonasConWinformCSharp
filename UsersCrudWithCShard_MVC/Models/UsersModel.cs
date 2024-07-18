using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace UsersCrudWithCShard_MVC.Models
{
    public class UsersModel
    {

        private int _id;
        private string _firstName;
        private string _lastName;
        private string _userName;
        private string _password;
        private string _email;

        [DisplayName]
        public int Id { get => _id; set => _id = value; }
        
        [DisplayName("Nombre")]
        [Required(ErrorMessage ="El nombre es requerido.")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "El nombre debe de longitud entre 3 a 25 caracteres")]
        public string FirstName { get => _firstName; set => _firstName = value; }

        [DisplayName("Apellido")]
        [Required(ErrorMessage = "El apellido es requerido.")]
        [StringLength(25,MinimumLength =3, ErrorMessage ="El apellido debe de longitud entre 3 a 25 caracteres")]
        public string LastName { get => _lastName; set => _lastName = value; }

        [DisplayName("Nombre de usuario")]
        [Required(ErrorMessage = "El nombre de usuario es requerido.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "El nombre de usuario debe de longitud entre 3 a 20 caracteres")]
        public string UserName { get => _userName; set => _userName = value; }

        [DisplayName("Contraseña")]
        [Required(ErrorMessage = "La contraseña es requerida.")]
        public string Password { get => _password; set => _password = value; }

        [DisplayName("Correo Electronico")]
        [Required(ErrorMessage = "El correo electronico es requerido.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El correo electronico debe de longitud entre 3 a 50 caracteres")]
        public string Email { get => _email; set => _email = value; }
    }
}
