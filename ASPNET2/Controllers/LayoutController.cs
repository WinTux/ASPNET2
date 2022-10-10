using Microsoft.AspNetCore.Mvc;

namespace ASPNET2.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PruebaSeccion()
        {
            return View();
        }

        public IActionResult LayoutsAnidados()
        {
            return View();
        }

    }
}
