using practicacalificada4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
{
    
}

namespace practicacalificada4.Data
{
    public class UsuarioContext : IdentityDbContext
    {
        public DbSet<Usuario> Usuarios {get;set;}

        public DbSet<RegistroUsuario> RegistroUsuarios  {get;set;}

        public UsuarioContext(DbContextOptions dco): base(dco){


        
        }
    }
}