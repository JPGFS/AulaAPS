using System;

namespace TDSN2024
{
    class TrianguloEquilatero : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 3 * Base;
        }

        public override string ToString()
        {
            return $"Triângulo Equilátero com Base = {Base} e Altura = {Altura}";
        }
    }
}