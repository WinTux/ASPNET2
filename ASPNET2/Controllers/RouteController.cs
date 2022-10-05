using Microsoft.AspNetCore.Mvc;

namespace ASPNET2.Controllers
{
    [Route("route")]
    public class RouteController : Controller
    {
        
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("obt")]
        public IActionResult Obtener()
        {
            return View("ejemploRoute");
        }
    }
}
