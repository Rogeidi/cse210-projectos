using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AtividadesIntrospeccao
{
    public class AtividadeListagem : Atividade
    {
        private List<string> _prompts;
        private Random _random;

        public AtividadeListagem() : base(
            "Atividade de Listagem",
            "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área.")

        {
            _random = new Random();

            _prompts = new List<string>
            {
                "Quem são as pessoas que você aprecia?",
                "Quais são seus pontos fortes pessoais?",
                "Quem são as pessoas que você ajudou esta semana?",
                "Quando você sentiu o Espírito Santo neste mês?",
                "Quem são alguns dos seus heróis pessoais?"
            };
        }

        public override void Executar()
        {
            ExibirMensagemInicial();

            int tempoTotal = GetDuracao();

            string promptSorteado = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine("\n--- Liste o máximo de itens que puder sobre o seguinte tema ---");
            Console.WriteLine($"\n> {promptSorteado} <");
            Console.WriteLine();

            Console.Write("Você começará em: ");
            ExibirContagemRegressiva(5);
            Console.WriteLine("\nComece a digitar os itens (pressione ENTER após cada um):");

            List<string> itensInseridos = new List<string>();

            Stopwatch cronometro = new Stopwatch();
            cronometro.Start();


            while (cronometro.Elapsed.TotalSeconds < tempoTotal)
            {
                Console.Write("- ");
                string item = Console.ReadLine();

                if (cronometro.Elapsed.TotalSeconds >= tempoTotal)
                {
                    Console.WriteLine("\nO tempo acabou!");
                    break;
                }

                if (!string.IsNullOrWhiteSpace(item))
                {
                    itensInseridos.Add(item);
                }
            }

            cronometro.Stop();

            Console.WriteLine();
            Console.WriteLine($"Excelente! Você conseguiu listar {itensInseridos.Count} itens!");

            ExibirMensagemFinal();

        }
    }
}
