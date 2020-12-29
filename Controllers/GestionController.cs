using Microsoft.AspNetCore.Mvc;
using practicacalificada4.Data;

namespace practicacalificada4.Controllers
{
    public class GestionController : Controller
    {
        private readonly UsuarioContext _context;
        public GestionController(UsuarioContext u)
        {
            _context = u;
        }

        [HttpPost]
        public IActionResult RegistrarTipoMascota(TipoMascota tm)
        {
          //TODO: Implement Realistic Implementation
          if (ModelState.IsValid){
              _context.Add(tm);
              _context.SaveChanges();
              return RedirectToAction("ListaTipoMascotas");
          }
          return View(tm);
          
        }
    }
}