namespace practicacalificada4.Data
{
    public class UsuarioContext : Dbcontext
    {
        public DbSet<Usuario> Usuarios {get;set;}

        public UsuarioContext (DbContextOption dco): base (dco){
            
        }
    }
}