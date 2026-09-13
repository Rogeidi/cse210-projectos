using System;

class Program
{
    static void Main(string[] args)
    {
        Diario meuDiario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        string opcao = "";

        Console.WriteLine("Bem-vindo ao programa de Diário Eletrônico!");

        while (opcao != "5")
        {
            Console.WriteLine("\nPor favor, escolha uma das seguintes opções:");
            Console.WriteLine("1. Escrever um novo registro");
            Console.WriteLine("2. Exibir o diário");
            Console.WriteLine("3. Carregar o diário de um arquivo");
            Console.WriteLine("4. Salvar o diário em um arquivo");
            Console.WriteLine("5. Sair");
            Console.WriteLine("O que você deseja fazer? ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    string pergunta = gerador.ObterPerguntaAleatoria();
                    Console.WriteLine($"\nPergunta: {pergunta}");
                    Console.WriteLine("> ");
                    string resposta = Console.ReadLine();

                    Registro novoRegistro = new Registro();
                    novoRegistro._data = DateTime.Now.ToShortDateString();
                    novoRegistro._textoPergunta = pergunta;
                    novoRegistro._textoResposta = resposta;

                    meuDiario.AdicionarRegistro(novoRegistro);
                    break;

                case "2":
                    Console.WriteLine("\n--- Registro do Diário ---");
                    meuDiario.ExibirTodos();
                    break;  

                case "3":
                    Console.Write("\nDigite o nome do arquivo para carregar (ex: diario.txt): ");
                    string arquivoLeitura = Console.ReadLine();
                    meuDiario.CarregadorDoArquivo(arquivoLeitura);
                    break;

                case "4":
                    Console.Write("\nDigite o nome do arquivo para salvar (ex: diario.txt): ");
                    string arquivoEscrita = Console.ReadLine();
                    meuDiario.SalvarNoArquivo(arquivoEscrita);
                    break;

                case "5":
                    Console.WriteLine("\nObrigada por usar o diário. Até logo!");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida! Por favor, escolha um número de 1 a 5.");
                    break;
            }
        }
    }
}