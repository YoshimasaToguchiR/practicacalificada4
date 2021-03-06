using System.ComponentModel.DataAnnotations;

namespace practicacalificada4.Models
{
    public class Usuario
    {
        public int Id{ get;set;}

        [Required]
        public string Nombre {get;set;}

        [Required]
        public string Apellidos {get;set;}

        [Required]
        [EmailAddress]
        public string Correo{get;set;}

        [Required]
        public string Contraseña{get;set;}





        public Fail Fail { get; set; }



        public int? FailId { get; set; }

    }
}