using System;
using System.Collections.Generic;


namespace Figuras
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaDeFiguras = new List<Figura>();

            listaDeFiguras.Add(new Quadrado("Azul", 5.0));
            listaDeFiguras.Add(new Retangulo("Vermelho", 4.0, 6.0));
            listaDeFiguras.Add(new Circulo("Verde", 3.0));

            Console.WriteLine("----- IMPRIMINDO AS FIGURAS DA LISTA -----");

            foreach (Figura figura in listaDeFiguras)
            {
                string tipoDaFigura = figura.GetType().Name;

                double areaCalculada = figura.ObterArea();

                Console.WriteLine($"{tipoDaFigura} -> Cor: {figura.Cor} | Área: {Math.Round(areaCalculada, 2)}");
            }
        }
    }
}