using Ejercicio04.Entidades;
using System.ComponentModel.DataAnnotations;
using UtilidadesPractico04;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Temperatures!");
            var grados = ExtensionesConsola.PedirDouble("Ingrese la temperatura en grados Celsius:");

            var t = new Temperatura(grados);

            var context = new ValidationContext(t);
            var errors=new List<ValidationResult>();

            var isValid=Validator.TryValidateObject(t,context,errors,true);
            if (isValid)
            {
                Console.WriteLine(t.ImprimirTemperatura());
                Console.WriteLine("Seleccione escala a convertir");
                Console.WriteLine("(F)ahrenheit");
                Console.WriteLine("(K)elvin");
                Console.Write("Ingrese selección:");
                var opcion = Console.ReadLine();
                Console.WriteLine($"{t.ConvertirAEscala(opcion)}");
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
