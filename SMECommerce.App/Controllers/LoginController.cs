using Microsoft.AspNetCore.Mvc;

namespace SMECommerce.App.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View("~/Views/Security/Login.cshtml");
        }
    }
}
