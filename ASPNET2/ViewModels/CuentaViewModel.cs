using ASPNET2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ASPNET2.ViewModels
{
    public class CuentaViewModel
    {
        public CuentaProgramador cuenta {get;set;}
        public List<LenguajeProg> lenguajes { get; set; }
        public SelectList cargos { get; set; }
    }
}
