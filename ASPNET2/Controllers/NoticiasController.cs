﻿using Microsoft.AspNetCore.Mvc;

namespace ASPNET2.Controllers
{
    public class NoticiasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Ejemplo1()
        {
            return View();
        }
        public IActionResult Ejemplo2()
        {
            return View();
        }
    }
}
