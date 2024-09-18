using System;

namespace TDSN2024
{
    class TrianguloIsosceles : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            double lado = Math.Sqrt(Math.Pow(Base / 2, 2) + Math.Pow(Altura, 2));
            return 2 * lado + Base;
        }

        public override string ToString()
        {
            return $"Triângulo Isósceles com Base = {Base} e Altura = {Altura}";
        }
    }
}