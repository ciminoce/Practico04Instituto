using Ejercicio05.Entidades;
using UtilidadesPractico04;

namespace Ejercicio5.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Points");
            var coordX = ExtensionesConsola.PedirEntero("Coord X del Punto:");
            var coordY = ExtensionesConsola.PedirEntero("Coord Y del Punto:");

            var punto =new Punto(coordX, coordY);
            Console.WriteLine(punto);
            var coordXOtro = ExtensionesConsola.PedirEntero("Coord X del Otro Punto:");
            var coordYOtro = ExtensionesConsola.PedirEntero("Coord Y del Otro Punto:");
            var otroPunto=new Punto(coordXOtro,coordYOtro);
            Console.WriteLine(punto.GetDistanciaOtroPunto(otroPunto));
        }
    }
}
