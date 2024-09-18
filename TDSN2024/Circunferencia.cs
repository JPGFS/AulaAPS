using System;

namespace TDSN2024
{
    class Circunferencia : FormaGeometrica
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

        public override string ToString()
        {
            return $"Circunferência com Raio = {Raio}";
        }
    }
}