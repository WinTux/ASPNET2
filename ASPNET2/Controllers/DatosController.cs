using ASPNET2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ASPNET2.Controllers
{
    public class DatosController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nombre = "Panqueque";
            ViewBag.disponible = true;
            ViewBag.precio = 7.2;
            ViewBag.cantidad = 15;
            ViewBag.fecha_elab = DateTime.Now;
            return View();
        }
        
        public IActionResult getObjeto()
        {

            
            Producto prod = new Producto { 
                Id = 1,
                nombre="Queso",
                precio = 15,
                cantidad = 20,
                imagen = "queso.jpg"
            };
            ViewBag.producto = prod;
            return View();
        }
        public IActionResult getObjetos()
        {

            List<Producto> prods = new List<Producto> {
                new Producto
            {
                Id = 1,
                nombre = "Compaq",
                precio = 1500,
                cantidad = 20,
                imagen = "comp01.jpg"
            },new Producto
            {
                Id = 2,
                nombre = "HP",
                precio = 3500,
                cantidad = 7,
                imagen = "comp02.jpg"
            },new Producto
            {
                Id = 3,
                nombre = "Macbook",
                precio = 4000,
                cantidad = 3,
                imagen = "comp03.jpeg"
            }
            };
            ViewBag.productos = prods;
            return View();
        }
    }
}
