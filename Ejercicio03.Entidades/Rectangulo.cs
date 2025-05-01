using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ejercicio03.Entidades
{
    public class Rectangulo:IValidatableObject
    {
        private int anchura;
        private int longitud;

        public Rectangulo(int anchura, int longitud)
        {
            this.anchura = anchura;
            this.longitud = longitud;
        }

        public int Anchura { get => anchura;  }
        public int Longitud { get => longitud;  }
        public double GetPerimetro()
        {
            return anchura*2+longitud*2;
        }
        public double GetSuperficie()
        {
            return anchura * longitud;
        }
        public double GetDiagonal()
        {
            return Math.Pow(Math.Pow(longitud, 2)+Math.Pow(anchura,2), 1.0/3.0);
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (anchura <= 0)
            {
                yield return new ValidationResult("La anchura debe ser positiva");
            }
            if (longitud <= 0)
            {
                yield return new ValidationResult("La longitud debe ser positiva");
            }
            if(anchura>0 && longitud>0 && anchura == longitud)
            {
                yield return new ValidationResult("Las medidas deben ser distintas");
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rectángulo de longitud: {longitud}");
            sb.AppendLine($"y anchura.............:{anchura}");
            sb.AppendLine($"Superficie............:{GetSuperficie():F2}");
            sb.AppendLine($"Perímetro.............:{GetPerimetro():F2}");
            sb.AppendLine($"Diagonal..............:{GetDiagonal():F2}");
            return sb.ToString();
        }

        public string MostrarInfo()
        {
            return $"Rectángulo=> ancho: {anchura} largo:{longitud}";
        }
    }
}
