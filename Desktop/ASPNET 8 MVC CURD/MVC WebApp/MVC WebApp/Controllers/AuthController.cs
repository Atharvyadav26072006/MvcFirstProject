 using Microsoft.AspNetCore.Mvc;

namespace MVC_WebApp.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registar()
        {
            //my name is atharv 
            return View();  
        }

    }
}
