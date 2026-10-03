using System;
using System.Collections.Generic;

namespace AtividadesIntrospeccao
{
    public class AtividadeReflexao : Atividade
    {
        private List<string> _temas;
        private List<string> _perguntas;
        private Random _random;

        public AtividadeReflexao() : base(
            "Atividade de Reflexão",
            "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência. Isso ajudará você a reconhecer o poder que você tem e como pode usá-lo em outros aspectos da sua vida.")

        {
            _random = new Random();

            _temas = new List<string>
            {
                "Pense em uma ocasião em que você defendeu outra pessoa.",
                "Pense em uma ocasião em que você fez algo realmente difícil.",
                "Pense em uma ocasião em que você ajudou alguém necessitado.",
                "Pense em uma ocasião em que você fez algo verdadeiramente altruísta."

            };

            _perguntas = new List<string>
            {
                "Por que essa experiência foi significativa para você?",
                "Você já fez algo assim antes?",
                "Como você começou?",
                "Como você se sentiu quando terminou?",
                "O que tornou esse momento diferente de outras vezes em que você não teve tanto sucesso?",
                "Qual é a sua coisa favorita sobre essa experiência?",
                "O que você pode aprender com essa experiência que se aplica a outras situações?",
                "O que você aprendeu sobre si mesmo por meio dessa experiência?",
                "Como você pode manter essa experiência em mente no futuro?"
            };
        }

        public override void Executar()
        {
            ExibirMensagemInicial();

            int tempoTotal = GetDuracao();
            int tempoDecorrido = 0;
            int tempoPorPergunta = 5;

            string temaAleatorio = _temas[_random.Next(_temas.Count)];
            Console.WriteLine("\n--- Considere a seguinte afirmação ---");
            Console.WriteLine($"\n> {temaAleatorio} <");
            Console.WriteLine("\nQuando estiver pronto, pressione ENTER para começar.");
            Console.ReadLine();

            Console.WriteLine("Pense nas seguintes perguntas conforme elas aparecem...");
            ExibirSpinner(3);
            Console.Clear();

            List<string> perguntasDisponiveis = new List<string>(_perguntas);

            while (tempoDecorrido < tempoTotal)
            {
                if (perguntasDisponiveis.Count == 0)
                {
                    perguntasDisponiveis = new List<string>(_perguntas);
                }

                int indexPergunta = _random.Next(perguntasDisponiveis.Count);
                string perguntaSorteada = perguntasDisponiveis[indexPergunta];

                perguntasDisponiveis.RemoveAt(indexPergunta);

                Console.WriteLine($"\n> {perguntaSorteada} ");

                int tempoDestaPausa = Math.Min(tempoPorPergunta, tempoTotal - tempoDecorrido);

                ExibirSpinner(tempoDestaPausa);
                tempoDecorrido += tempoDestaPausa;
                Console.WriteLine();
            }

            ExibirMensagemFinal();
        }

    }
}