using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace practicacalificada4.Models
{
    public class Fail
    {
        public int Id{get;set;}


        
        public string Nombre {get;set;}

        public string Descripcion {get;set;}

        

        public ICollection<Usuario> Usuarios { get; set; }
    }
}