using Microsoft.AspNetCore.Mvc;

namespace ASPNET2.Controllers
{
    public class MultiplesSubmitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ejemplo1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ejemplo2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ejemplo3()
        {
            return View();
        }
    }
}
