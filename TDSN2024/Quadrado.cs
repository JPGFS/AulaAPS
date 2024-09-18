using System;

namespace TDSN2024
{
    class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Math.Pow(Lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        public override string ToString()
        {
            return $"Quadrado com Lado = {Lado}";
        }
    }
}
