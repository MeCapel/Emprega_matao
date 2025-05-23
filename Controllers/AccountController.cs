using Microsoft.AspNetCore.Mvc;

namespace projeto_integrador.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult CadastroPJ()
        {
            return View();
        }

        public IActionResult CadastroPF()
        {
            return View();
        }
    }
}
