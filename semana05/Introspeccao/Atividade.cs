using System;
using System.Collections.Generic;
using System.Threading;

namespace AtividadesIntrospeccao
{
    public abstract class Atividade
    {
        private string _nome;
        private string _descricao;
        private int _duracao;

        protected Atividade(string nome, string descricao)
        {
            _nome = nome;
            _descricao = descricao;
        }

        protected string GetNome() => _nome;
        protected int GetDuracao() => _duracao;

        public void ExibirMensagemInicial()
        {
            Console.Clear();
            Console.WriteLine($"--- Bem-vindo à {_nome} ---");
            Console.WriteLine();
            Console.WriteLine(_descricao);
            Console.WriteLine();
            Console.Write("Quantos segundos você deseja para esta atividade? ");


            while (!int.TryParse(Console.ReadLine(), out _duracao) || _duracao <= 0)
            {
                Console.Write("Por favor, insira um número válido de segundos: ");
            }

            Console.Clear();
            Console.WriteLine("Prepare-se para começar...");
            ExibirSpinner(3);
        }

        public void ExibirMensagemFinal()
        {
            Console.WriteLine();
            Console.WriteLine("Muito bem! Você fez um ótimo trabalho.");
            ExibirSpinner(2);
            Console.WriteLine($"Você concluiu a atividade: {_nome} com a duração de {_duracao} segundos!");
            ExibirSpinner(4);
        }

        protected void ExibirSpinner(int segundos)
        {
            List<string> animacao = new List<string> { "|", "/", "-", "\\" };
            DateTime tempoLimite = DateTime.Now.AddSeconds(segundos);

            int i = 0;
            while (DateTime.Now < tempoLimite)
            {
                string caractere = animacao[i];
                Console.Write(caractere);
                Thread.Sleep(250);
                Console.Write("\b \b");

                i++;
                if (i >= animacao.Count)
                {
                    i = 0;
                }
            }
        }

        protected void ExibirContagemRegressiva(int segundos)
        {
            for (int i = segundos; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

        public abstract void Executar();
    }
}
