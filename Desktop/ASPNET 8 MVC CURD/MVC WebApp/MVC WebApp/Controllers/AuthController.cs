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
            return View();  
        }
    }
}
