using System;

namespace AtividadesIntrospeccao

{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("============================================");
                Console.WriteLine("     MENU DE ATIVIDADES DE INTROSPECÇÃO     ");
                Console.WriteLine("============================================");
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1. Iniciar Atividade de Respiração");
                Console.WriteLine("2. Iniciar Atividade de Reflexão");
                Console.WriteLine("3. Iniciar Atividade de Listagem");
                Console.WriteLine("4. Sair do Programa");
                Console.WriteLine("=============================================");
                Console.Write("Digete a sua opção (1-4): ");

                string opcao = Console.ReadLine();

                Atividade atividadeSelecionada = null;

                switch (opcao)
                {
                    case "1":

                        atividadeSelecionada = new AtividadeRespiracao();
                        break;

                    case "2":

                        atividadeSelecionada = new AtividadeReflexao();
                        break;

                    case "3":

                        atividadeSelecionada = new AtividadeListagem();
                        break;

                    case "4":
                        Console.WriteLine("\nObrigado por utilizar o programa. Até logo!");
                        Console.ReadKey();

                        continuar = false;
                        
                        break;
                }

                if (atividadeSelecionada != null)
                {
                    atividadeSelecionada.Executar();
                }
            }
        }
    }
}

