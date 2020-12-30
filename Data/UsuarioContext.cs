using practicacalificada4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
{
    
}

namespace practicacalificada4.Data
{
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuario {get;set;}

        public DbSet<RegistroUsuario> RegistroUsuario  {get;set;}

        public UsuarioContext(DbContextOptions dco): base(dco){


        
        }
    }
}