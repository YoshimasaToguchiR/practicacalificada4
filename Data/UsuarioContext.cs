using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using practicacalificada4.Models;

namespace practicacalificada4.Data
{
    public class UsuarioContext :  IdentityDbContext
    {
        public DbSet<Usuario> Usuarios{get;set;}

        public DbSet<Fail> Fails{get;set;}
        public UsuarioContext(DbContextOptions dco): base(dco){
            
        }
    }
}