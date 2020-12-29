using System.Linq;
using Microsoft.AspNetCore.Mvc;
using practicacalificada4.Data;
using practicacalificada4.Models;

namespace practicacalificada4.Controllers
{
    public class GestionController : Controller
    {
        private readonly UsuarioContext _context;
        public GestionController(UsuarioContext c)
        {
            _context = c;
        }

        public IActionResult RegistroUsuario()
        {
          //TODO: Implement Realistic Implementation
          return View();
        }
        [HttpPost]
        public IActionResult RegistroUsuario(RegistroUsuario ru)
        {
          //TODO: Implement Realistic Implementation
          if (ModelState.IsValid){
                _context.Add(ru);
                _context.SaveChanges();
              return RedirectToAction("Index");
          }
          return View(ru);
          
        }

        
    }
}