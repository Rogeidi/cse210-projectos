using System;
public class Fracao
        
    {
        private int _numerador;

        private int _denomidador;

        public Fracao()
        {
            _numerador = 1;
            _denomidador = 1;
        }
        public Fracao(int numeroInteiro)
        {
            _numerador = numeroInteiro;
            _denomidador = 1;
        } 
        public Fracao(int numerador, int denomidador)
        {
            _numerador = numerador;
            _denomidador = denomidador;
        }

        public string ObterFracaoEmTexto()
        {
            string texto = $"{_numerador}/{_denomidador}";
            return texto; 
        }

        public double ObterFracaoEmDecimal()
        {
            return (double)_numerador / _denomidador;
        }
        
    }