using System.Text;

namespace Ejercicio05.Entidades
{
    public enum Cuadrante
    {
        Origen,
        PrimerCuadrante,
        SegundoCuadrante,
        TercerCuadrante,
        CuartoCuadrante,
        EjeXPositivo,
        EjeXNegativo,
        EjeYPositivo,
        EjeYNegativo
    }
    public class Punto
    {
        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }

        //public double DistanciaAlOrigen()
        //{
        //    return Math.Sqrt(Math.Pow(X,2)+Math.Pow(Y,2));
        //}
        public string CoordenadasPolares()
        {
            //var r = DistanciaAlOrigen();
            var r = GetDistanciaOtroPunto();
            var theta = Math.Atan2(Y,X);
            return $"({r:F1},{theta:F2})";
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Punto:({X}, {Y})");
            sb.AppendLine($"Coord. Polares: {CoordenadasPolares()}");
            sb.AppendLine($"En Cuadrante: {GetCuadrante()}");
            return sb.ToString();

        }
        public Cuadrante GetCuadrante()
        {
            if (X == 0 && Y == 0) return Cuadrante.Origen;
            if (X > 0 && Y > 0) return Cuadrante.PrimerCuadrante;
            if (X < 0 && Y > 0) return Cuadrante.SegundoCuadrante;
            if (X < 0 && Y < 0) return Cuadrante.TercerCuadrante;
            if (X >0 && Y < 0) return Cuadrante.CuartoCuadrante;
            if (X > 0 && Y == 0) return Cuadrante.EjeXPositivo;
            if (X < 0 && Y == 0) return Cuadrante.EjeXNegativo;
            if(X==0 && Y>0)return Cuadrante.EjeYPositivo;
            return Cuadrante.EjeYNegativo;
        }

        public double GetDistanciaOtroPunto(Punto? otroPunto=null)
        {
            if (otroPunto is not null)
            {
                return Math.Sqrt(Math.Pow(X - otroPunto.X, 2) + Math.Pow(Y - otroPunto.Y, 2));

            }
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));

        }
    }
}
