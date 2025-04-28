using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ejercicio04.Entidades
{
    public class Temperatura:IValidatableObject
    {
        private double celsius;

        public Temperatura(double celsius)
        {
            Celsius = celsius;
        }

        public double Celsius { get => celsius; set => celsius = value; }

        public string ConvertirAEscala(string opcion)
        {
            double conversion;
            switch (opcion.ToUpper())
            {
                case "F":
                    conversion = ConvertirCelsiusFahrenheit();
                    return $"{this.ToString()} equivalen a {conversion:F1}ºF";
                case "K":
                    conversion = ConvertirCelsiusKelvin();
                    return $"{this.ToString()} equivalen a {conversion:F1}ºK";
                default:
                    return "Escala de conversión mal ingresada";
            }
        }

        public double ConvertirCelsiusFahrenheit()
        {
            return 1.8 * Celsius + 32;
        }
        public double ConvertirCelsiusKelvin()
        {
            return Celsius+ 274.15;
        }
        public string ImprimirTemperatura()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Temperatura");
            sb.AppendLine($"Celsius: {Celsius:F1}");
            sb.AppendLine($"Fahrenheit: {ConvertirCelsiusFahrenheit():F1}");
            sb.AppendLine($"Kelvin: {ConvertirCelsiusKelvin():F2}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return $"{Celsius:F1}ºC";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!EsValidaCantidadDecimales())
            {
                yield return new ValidationResult("Temperatura con más de un decimal");
            }

            if (Celsius<-80 || Celsius > 80)
            {
                yield return new ValidationResult("Temperatura fuera del rango permitido [-80,80]");
            }
        }
        private bool EsValidaCantidadDecimales()
        {
            var resultado = Celsius * 10;
            return resultado == Math.Floor(Celsius * 10);
        }
    }
}
