using System;
using System.Reflection.PortableExecutable;

namespace Figuras
{
    public class Figura
    {
        private string _cor;

        public string Cor
        {
            get { return _cor; }
            set { _cor = value; }
        } 

        public Figura(string cor)
        {
            _cor = cor;
        }

        public virtual double ObterArea()
        {
            return 0;
        }
    }
}