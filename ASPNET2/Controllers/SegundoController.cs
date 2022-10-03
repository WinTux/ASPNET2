using Microsoft.AspNetCore.Mvc;

namespace ASPNET2.Controllers
{
    public class SegundoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tercero()
        {
            return View();
        }
    }
}
