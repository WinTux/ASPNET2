using System.Collections.Generic;

namespace ASPNET2.Models
{
    public class CuentaProgramador
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }
        public string cargo { get; set; }//Ej. J01 S02
        public string genero { get; set; }
        public List<string> leguajes_prog { get; set; }// lp01 lp02


    }
}
