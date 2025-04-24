using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ejercicio01.Entidades
{
    public class Cuadrado:IValidatableObject
    {
        private double lado;
        public Cuadrado()
        {
            
        }
        public Cuadrado(double lado)
        {
            Lado = lado;
        }
        
        public double Lado { get => lado; set => lado = value; }
        public double CalcularPerimetro()
        {
            return Lado * 4;
        }
        public double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }
        public string ImprimirInformacion()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Cuadrado de lado: {Lado}");
            sb.AppendLine($"Perímetro.......: {CalcularPerimetro()}");
            sb.AppendLine($"Superficie......: {CalcularArea()}");
            return sb.ToString();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //var listaErrores=new List<ValidationResult>();
            //if (Lado<=0)
            //{
            //    var validationResult = new ValidationResult("El lado no puede ser nulo o negativo");
            //    listaErrores.Add(validationResult);
            //}
            //return listaErrores;
            if (Lado <= 0)
            {
                yield return new ValidationResult("El lado no puede ser nulo o negativo");
            }
        }

        public override string ToString()
        {
            return $"Cuadrado de lado: {Lado}";
        }
    }
}
