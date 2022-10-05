using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ASPNET2.Controllers
{

     
    public class ConfiguracionesController : Controller
    {

        private IConfiguration configuracion;
        public ConfiguracionesController(IConfiguration configuracion) {
            this.configuracion = configuracion;
        }
        public IActionResult Index()
        {
            ViewBag.mensaje = configuracion["Mensaje"];
            ViewBag.log = configuracion["MisConfiguraciones:Debug:LogHabilitado"];
            ViewBag.traza = configuracion["MisConfiguraciones:Traza"];
            return View();
        }
    }
}
