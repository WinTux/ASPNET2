using ASPNET2.Models;
using ASPNET2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASPNET2.Controllers
{
    public class CuentaController : Controller
    {
        public IActionResult Index()
        {
            var cuentaVM = new CuentaViewModel();
            cuentaVM.cuenta = new CuentaProgramador() {
                id = 100,
                activo = true,
                genero = "M" //M=Masculiuno; F=Femenino
            };
            cuentaVM.lenguajes = new List<LenguajeProg>() { 
                new LenguajeProg(){ 
                    id = "lp01",
                    nombre = "C#",
                    marcado = true
                },
                new LenguajeProg(){
                    id = "lp02",
                    nombre = "C++",
                    marcado = false
                },
                new LenguajeProg(){
                    id = "lp03",
                    nombre = "Java",
                    marcado = true
                },new LenguajeProg(){
                    id = "lp04",
                    nombre = "Python",
                    marcado = false
                }
            };
            var c = new List<Cargo>() { 
                new Cargo { id = "c01", nombre = "Jefe"},
                new Cargo { id = "c02", nombre = "Jefe de departamento"},
                new Cargo { id = "c03", nombre = "Operador"}
            };

            cuentaVM.cargos = 
                new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                    c, "id", "nombre");
            return View("Index", cuentaVM);
        }

        [HttpPost]
        public IActionResult Registrar(CuentaViewModel cuentaVM, List<LenguajeProg> lenguajes) {

            cuentaVM.cuenta.leguajes_prog = new List<string>();
            foreach (var len in lenguajes) 
                if (len.marcado)
                    cuentaVM.cuenta.leguajes_prog.Add(len.id);
            ViewBag.cuenta = cuentaVM.cuenta;
            return View("Exito");
        }
    }


}
