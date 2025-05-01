using Ejercicio03.Entidades;
using System.ComponentModel.DataAnnotations;
using UtilidadesPractico04;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Rectangulos");

            var anchura = ExtensionesConsola.PedirEntero("Ingrese el valor del ancho del rectángulo:");
            var longitud = ExtensionesConsola.PedirEntero("Ingrese el valor de la longitud del rectángulo:");

            Rectangulo r=new Rectangulo(anchura, longitud);
            
            var context=new ValidationContext(r);
            var errors=new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(r, context, errors, true);
            if (isValid)
            {
                Console.WriteLine(r);
            }
            else
            {
                foreach (var error in errors)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}
