using System;
using System.Collections.Generic;

namespace AcademiaApp
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Atividade> listaDeAtividades = new List<Atividade>();

            Corrida corrida = new Corrida("03 Nov 2022", 30, 4.8);
            Ciclismo ciclismo = new Ciclismo("04 Nov 2022", 45, 20.0);
            Natacao natacao = new Natacao("05 Nov 2022", 40, 30);

            listaDeAtividades.Add(corrida);
            listaDeAtividades.Add(ciclismo);
            listaDeAtividades.Add(natacao);

            Console.WriteLine("--- RESUMO DA ATIVIDADES DA ACADEMIA ---");
            foreach (Atividade atividade in listaDeAtividades)
            {
                Console.WriteLine(atividade.ObterResumo());
            }

        }
    }
}