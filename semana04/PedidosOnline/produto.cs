using System;

namespace SistemaPedidos
{
    public class Produto
    {
        //Campos privados
        private string _nome;
        private string _id;
        private double _preco;
        private int _quantidade;

        // Propiedades 
        public string Nome => _nome;
        public string Id => _id;
        public double Preco => _preco;
        public int Quantidade => _quantidade;

        public Produto(string nome, string id, double preco, int quantidade)
        {
            _nome = nome;
            _id = id;
            _preco = preco;
            _quantidade = quantidade;
        }

        public double CalcularCustoTotal()
        {
            return _preco * _quantidade;
        }
    }
}