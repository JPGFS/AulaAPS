using System;

namespace TDSN2024
{
    class TrianguloReto : FormaGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }

        public override double CalcularPerimetro()
        {
            double hipotenusa = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
            return Base + Altura + hipotenusa;
        }

        public override string ToString()
        {
            return $"Triângulo Reto com Base = {Base} e Altura = {Altura}";
        }
    }
}
