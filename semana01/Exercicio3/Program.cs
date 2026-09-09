using System;

class Program
{
    static void Main(string[] args)
    {
        Random generadorRandomico = new Random();
        int numeroMagico = generadorRandomico.Next(1, 101);

        int palpite = -1;

        while (palpite != numeroMagico)
        {
            Console.WriteLine("Qual é o seu palpite? ");
            palpite = int.Parse(Console.ReadLine());

            if (numeroMagico > palpite)
            {
                Console.WriteLine("Mais alto");
            }

            else if (numeroMagico < palpite)
            {
                Console.WriteLine("Mais baixo");
            }
            else
            {
                Console.WriteLine("Você adivinhou!");
            }
        }

    }
}