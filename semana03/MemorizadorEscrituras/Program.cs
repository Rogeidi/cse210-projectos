using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        List<Escritura> bancoDeEscrituras = new List<Escritura>();

        Referencia referencia1 = new Referencia("Provérbios", 3, 5, 6);
        string textoEscritura1 = "Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento";
        bancoDeEscrituras.Add(new Escritura(referencia1, textoEscritura1));

        Referencia referencia2 = new Referencia("Filipenses", 4, 13);
        string textoEscritura2 = "Posso todas as coisas naquele que me fortalece";
        bancoDeEscrituras.Add(new Escritura(referencia2, textoEscritura2));

        Referencia referencia3 = new Referencia("Salmos", 23, 1);
        string textoEscritura3 = "O Senhor é o meu pastor, nada me faltará";
        bancoDeEscrituras.Add(new Escritura(referencia3, textoEscritura3));

        Referencia referencia4 = new Referencia("João", 14, 6);
        string textoEscritura4 = "Disse-lhe Jesus: Eu sou o caminho, e a verdade, e a vida; ninguém vem ao Pai senão por mim";
        bancoDeEscrituras.Add(new Escritura(referencia4, textoEscritura4));

        Random random = new Random();
        int indiceAleatorio = random.Next(bancoDeEscrituras.Count);
        Escritura escritura = bancoDeEscrituras[indiceAleatorio];
        

        while (true)
        {
            Console.Clear();         

            Console.WriteLine(escritura.ObterTextoExibicao());
            Console.WriteLine();

            if (escritura.CompletamenteEscondida())
            {
                Console.WriteLine("Parabéns! Todas as palavras foram escondidas. Programa encerrado.");
                break;
            }

            Console.WriteLine("Pressione Enter para esconder palavras ou digite 'sair' para encerrar: ");
            string entradaUsuario = Console.ReadLine();

            if (entradaUsuario.ToLower() == "sair")
            {
                break;
            }

            escritura.EsconderPalavrasAleatorias(3);
        }
    }
}