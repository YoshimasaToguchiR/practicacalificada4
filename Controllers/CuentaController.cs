using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace practicacalificada4.Controllers
{
    public class CuentaController : Controller

    {
        private readonly UserManager<IdentityUser> _um;
        private readonly SignInManager<IdentityUser> _sm;
        public CuentaController(UserManager<IdentityUser> um, SignInManager<IdentityUser> sim){
            
            _um = um;
        }



        public IActionResult Registro(){
            return View();
        }

        public IActionResult Login(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(string correo , string contraseña)


        {
           var result = _sm.PasswordSignInAsync(correo , contraseña, false, false).Result;

           if(result.Succeeded){
               return RedirectToAction("Index", "Home");

           }
           ModelState.AddModelError("", "Correo y/o contraseña es incorrecta");
            return View();
        }

        [HttpPost]
        public IActionResult Registro(string correo, string contraseña){

            var user = new IdentityUser();
            user.Email = correo;
            user.UserName = correo;

            var result = _um.CreateAsync(user, contraseña ).Result;
            
            if(result.Succeeded){
                return RedirectToAction("Index","Home");
            }

            foreach( var  error in result.Errors){
            ModelState.AddModelError("", error.Description);
            }

            return View();
        }

         

    }
}