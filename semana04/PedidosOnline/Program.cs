using System;

namespace SistemaPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Endereco endereco1 = new Endereco("123 Fifth Avenue", "New York", "NY", "EUA");
            Cliente cliente1 = new Cliente("John Doe", endereco1);
            Pedido pedido1 = new Pedido(cliente1);

            pedido1.AdicionarProduto(new Produto("Notebook Gamer", "PROD001", 1200.00, 1));
            pedido1.AdicionarProduto(new Produto("Mouse Sem Fio", "PROD002", 45.50, 2));


            Endereco endereco2 = new Endereco("Av. Pauista, 1000", "São Paulo", "SP", "Brasil");
            Cliente cliente2 = new Cliente("Maria Silva", endereco2);
            Pedido pedido2 = new Pedido(cliente1);

            pedido2.AdicionarProduto(new Produto("Livro de C#", "PROD003", 89.90, 3));
            pedido2.AdicionarProduto(new Produto("Caneca Térmica", "PROD004", 120.00, 1));

            
            Console.WriteLine("=================================================");
            Console.WriteLine("         SISTEMA DE PEDIDOS INTERNACIONALES       ");
            Console.WriteLine("=================================================\n");

            Console.WriteLine(">>> PROCESSANDO PEDIDO 1 <<<");
            Console.WriteLine(pedido1.GerarEtiquetaEmbalagem());
            Console.WriteLine(pedido1.GerarEtiquetaEnvio());
            Console.WriteLine($"VALOR TOTAL DO PEDIDO (com frete): ${pedido1.CalcularCustoTotalPedido():F2}");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine();


            Console.WriteLine(">>> PROCESSANDO PEDIDO 2 <<<");
            Console.WriteLine(pedido2.GerarEtiquetaEmbalagem());
            Console.WriteLine(pedido2.GerarEtiquetaEnvio());
            Console.WriteLine($"VALOR TOTAL DO PEDIDO (com frete): ${pedido2.CalcularCustoTotalPedido():F2}");
            Console.WriteLine(new string('=', 50));
            Console.WriteLine();

            Console.ReadLine();            
        }
    }
}