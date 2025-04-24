using Ejercicio01.Entidades;
using System.ComponentModel.DataAnnotations;
using UtilidadesPractico04;

namespace Ejercicio01.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Quadra2");
            var lado = ExtensionesConsola.PedirDouble("Ingrese la medida del lado:");
            var c = new Cuadrado(lado);
            var context=new ValidationContext(c);
            var errores=new List<ValidationResult>();
            bool esValido=Validator.TryValidateObject(c, context,errores,true);
            if (!esValido)
            {
                foreach (var item in errores)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine(c.ImprimirInformacion());

            }
        }
    }
}
