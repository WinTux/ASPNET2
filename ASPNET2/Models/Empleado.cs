using System.ComponentModel.DataAnnotations;

namespace ASPNET2.Models
{
    public class Empleado
    {
        [Required(ErrorMessage = "Debe poner un nombre valido")]
        [MinLength(3)]
        [MaxLength(30)]
        public string nombre { get; set; }

        [Required]
        [MinLength(3,ErrorMessage ="La longitud mínima es 3")]
        [MaxLength(30)]
        [RegularExpression("\\d{3,4}[a-zA-Z]{3}")]
        public string password { get; set; }
        /*
         \d -> un dígito
        \d{3} -> 3 dígitos
        \d{3,} -> 3 dígitos o más
        \d{3,6} -> de 3 a 6 dígitos
        ^\d{3} -> 3 dígitos al inicio
        [abc] -> se permite una letra: a, b ó c
        [a-l] -> se admite una letra entre la a y la l
        r* -> se espera cero o muchas veces la letra r
        r+ -> se espera una o muchas veces la letra r

        Ejemplo corto: placas de autos
        \d{3,4}[a-zA-Z]{3}

        1234FER

         */

        [Required]
        [Range(18,40)]
        public int edad { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Url]
        public string pagina { get; set; }
    }
}
