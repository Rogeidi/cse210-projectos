using System;
using System.Collections.Generic;

namespace MetasEternas
{

    class Program
    {
        static List<Meta> _metas = new List<Meta>();
        static int _pontuacaoTotal = 0;
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine($"--- METAS ETERNAS ---");
                Console.WriteLine($"Pontuação Atual: {_pontuacaoTotal} pontos\n");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1. Criar Nova Meta");
                Console.WriteLine("2. Listar Metas");
                Console.WriteLine("3. Registrar Evento (Meta Cumprida)");
                Console.WriteLine("4. Salvar Metas");
                Console.WriteLine("5. Carregar Metas");
                Console.WriteLine("6. Sair");
                Console.Write("\nEscolha: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CriarNovaMeta();
                        break;

                    case "2":
                        ListarMetas();
                        break;

                    case "3":
                        RegistrarEventoMeta();
                        break;

                    case "4":
                        Console.WriteLine("Funcionalidade de Salvar será implementada em breve...");
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Funcionalidade de Carregar será implementada em breve...");
                        Console.ReadKey();
                        break;

                    case "6":
                        continuar = false;
                        Console.WriteLine("Obrigado por usar o Metas Eternas. Até logo!");
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ListarMetas()
        {
            Console.Clear();
            Console.WriteLine("--- SUAS METAS ---");

            if (_metas.Count == 0)
            {
                Console.WriteLine("Você ainda não criou nenhuma meta.");
            }
            else
            {
                for (int i = 0; i < _metas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhesAlvo()}");

                }
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

        static void CriarNovaMeta()
        {
            Console.Clear();
            Console.WriteLine("--- CRIAR NOVA META ---");
            Console.WriteLine("1. Meta Simples");
            Console.WriteLine("2. Meta Eterna (Ainda não criada)");
            Console.WriteLine("3. Meta Lista (Ainda não criada)");
            Console.Write("\nEscolha o tipo de meta: ");

            string tipo = Console.ReadLine();

            if (tipo != "1" && tipo != "2")
            {
                Console.WriteLine("\nOpção inválida ou tipo ainda não implementado!.");
                Console.ReadKey();
                return;
            }

            Console.Write("Digite o nome da meta: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a descrição: ");
            string descricao = Console.ReadLine();

            Console.Write("Quantos pontos ela vale? ");
            int pontos = int.Parse(Console.ReadLine());

            if (tipo == "1")
            {
                MetaSimples novaMeta = new MetaSimples(nome, descricao, pontos);
                _metas.Add(novaMeta);
            }
            else if (tipo == "2")
            {
                MetaEterna novaMeta = new MetaEterna(nome, descricao, pontos);
                _metas.Add(novaMeta);
            }   

            Console.WriteLine("\nMeta criada com sucesso!");
            Console.ReadKey();

        }

        static void RegistrarEventoMeta()
        {
            Console.Clear();
            Console.WriteLine("--- RegistrarEventoMeta EVENTO ---");

            if (_metas.Count == 0)
            {
                Console.WriteLine("Não há metas cadastradas para registrar.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < _metas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_metas[i].Nome}");
            }

            Console.Write("\nQual meta você cumpriu? Digite o número: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < _metas.Count)
            {
                int pontosGanhos = _metas[indice].RegistrarEvento();
                _pontuacaoTotal += pontosGanhos;

                Console.WriteLine($"\nParabéns Você ganhou {pontosGanhos} pontos.");

            }
            else
            {
                Console.WriteLine("Número inválida!");
            }

            Console.ReadKey();
        }
    }
}