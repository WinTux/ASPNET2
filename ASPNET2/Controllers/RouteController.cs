using Microsoft.AspNetCore.Mvc;

namespace ASPNET2.Controllers
{
    [Route("route")]
    public class RouteController : Controller
    {
        
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("obt")]
        public IActionResult Obtener()
        {
            return View("ejemploRoute");
        }
        //Sobre parámetros
        [Route("getValor/{nombre}")]
        public IActionResult getValor(string nombre)
        {
            ViewBag.nom = nombre;
            return View("ejemploRoute");
        }

        [Route("getValores/{empleado}/{telefono}")]
        public IActionResult getValores(string empleado, int telefono)
        {
            ViewBag.emp = empleado;
            ViewBag.tel = telefono;
            return View("ejemploRoute2");
        }

        //Sobre query strings
        [Route("ejemplo1query")]
        public IActionResult ejemplo1query([FromQuery(Name ="id")] string id)
        {
            ViewBag.idemp = id;
            return View("ejemploRoute3");
        }
        [Route("ejemplo1query2")]
        public IActionResult ejemplo1query2(
            [FromQuery(Name = "id")] string id, 
            [FromQuery(Name ="apellido")] string ap
        )
        {
            ViewBag.idemp = id;
            ViewBag.idapellido = ap;
            return View("ejemploRoute4");
        }

        [Route("ejemplo1query3")]
        public IActionResult ejemplo1query3()
        {
            string id = HttpContext.Request.Query["id"].ToString();
            //int num = int.Parse(HttpContext.Request.Query["id"].ToString());
            string ape = HttpContext.Request.Query["apellido"].ToString();
            ViewBag.idemp = id;
            ViewBag.idapellido = ape;
            return View("ejemploRoute4");
        }
    }
}
