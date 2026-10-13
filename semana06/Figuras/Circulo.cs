using System;

namespace Figuras
{
    public class Circulo : Figura
    {
        private double _raio;

        public Circulo(string cor, double raio) : base(cor)
        {
            _raio = raio;
        }

        public override double ObterArea()
        {
            return Math.PI * Math.Pow(_raio, 2);
        }
    }
}