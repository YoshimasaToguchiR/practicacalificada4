using System.Linq;
using Microsoft.AspNetCore.Mvc;
using practicacalificada4.Data;
using practicacalificada4.Models;

namespace practicacalificada4.Controllers
{
    public class GestionController : Controller
    {

        private readonly UsuarioContext _context;
        public GestionController(UsuarioContext c){

                _context= c;
        }

        public IActionResult ListaFails()
        {
            var lista = _context.Fails.ToList();
          
          return View(lista);
        }

        public IActionResult RegistrarFail()
        {
          
          return View();
        }

        [HttpPost]
        public IActionResult RegistrarFail(Fail f)
        {
            if(ModelState.IsValid){
                _context.Add(f);
                _context.SaveChanges();
                return RedirectToAction("ListaFails");

            }
            return View(f);
          
          
        }
    }
}