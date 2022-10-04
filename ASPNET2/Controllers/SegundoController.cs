using Microsoft.AspNetCore.Mvc;

namespace ASPNET2.Controllers
{
    [Route("prueba")] // http://localhost:puerto/prueba
    public class SegundoController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("vista")] // http://localhost:puerto/prueba/vista
        [Route("principal")] // http://localhost:puerto/prueba/principal
        public IActionResult Tercero()
        {
            return View();
        }

    }
}
