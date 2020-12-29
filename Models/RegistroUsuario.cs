using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace practicacalificada4.Models
{
    public class RegistroUsuario
    {
        public int Id{get;set;}

        [Required]
        public string Nombre{get;set;}

        public string Apellido{get;set;}

        public string Correo{get;set;}

        public string Contraseña{get;set;}

        public ICollection<Usuario> Usuarios {get;set;}
    }
}