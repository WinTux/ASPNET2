using ASPNET2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET2.Controllers
{
    public class EmpeladoController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", new Empleado());
        }

        //Registrar
        [HttpPost]
        public IActionResult Registrar(Empleado emp)
        {

            if(ModelState.IsValid)
                return View("Exito");
            else
                return View("Index");
        }
    }
}
