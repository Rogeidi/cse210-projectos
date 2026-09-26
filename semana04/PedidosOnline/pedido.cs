using System;
using System.Collections.Generic;

namespace SistemaPedidos
{
    public class Pedido
    {
        private List<Produto> _produtos;
        private Cliente _cliente;

        public Pedido(Cliente cliente)
        {
            _cliente = cliente;
            _produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            _produtos.Add(produto);
        }

        public double CalcularCustoTotalPedido()
        {
            double subtotalProdutos = 0;

            foreach (Produto produto in _produtos)
            {
                subtotalProdutos  += produto.CalcularCustoTotal();
            }

            double custoEnvio = _cliente.MoraNosEua() ? 5.0 : 35.0;

            return subtotalProdutos + custoEnvio;
        }

        public string GerarEtiquetaEmbalagem()
        {
            string etiqueta = "---ETIQUETA DE EMBALAGEM ---\n";
            foreach (Produto produto in _produtos)
            {
                etiqueta += $"ID: {produto.Id} | Produto: {produto.Nome} (x{produto.Quantidade})\n";
            } 
            return etiqueta;
        }

        public string GerarEtiquetaEnvio()
        {
            string etiqueta = "--- ETIQUETA DE ENVIO ---\n";
            etiqueta += $"Destinatário: {_cliente.Nome}\n";
            etiqueta += $"Endereço:\n{_cliente.Endereco.ObterEnderecoCompleto()}\n";
            return etiqueta;
        }
    }
}