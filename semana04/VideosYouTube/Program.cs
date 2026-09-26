using System;
using System.Collections.Generic;
using MonitoramentoYoutube;

namespace MonitoramentoYoutube 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando os vídeos
            Video video1 = new Video("Como Aprender C# em 2026", "DevPro", 720);
            Video video2 = new Video("Review do Novo Smartphone XYZ", "TechMundo", 450);
            Video video3 = new Video("Receita de Bolo de Cenoura Perfeito", "Chef Em Casa", 300);

            // Adicionando os comentários
            video1.AdicionarComentario(new Comentario("Carlos Silva", "Excelente vídeo! Me ajudou muito a entender classe."));
            video1.AdicionarComentario(new Comentario("Ana Souza", "A didática desse canal é sensacional."));
            video1.AdicionarComentario(new Comentario("Pedro Santos", "Quero a parte 2 sobre APIs!"));


            video2.AdicionarComentario(new Comentario("Maria lima", "O desing desse celular ficou lindo, mas o preço está alto."));
            video2.AdicionarComentario(new Comentario("João Lucas", "Vale mais a pena comprar o modelo do ano passado?"));
            video2.AdicionarComentario(new Comentario("Beatriz Costa", "Belo review, bem direto ao ponto."));
       
       
            video3.AdicionarComentario(new Comentario("Ricardo Alves", "Fiz aqui e deu super certo! Fofinho."));
            video3.AdicionarComentario(new Comentario("Fernanda Oliveira", "Pode substituir o açucar por adoçante culinario?"));
            video3.AdicionarComentario(new Comentario("Juliana Reis", "Essa calda de chocolate é a melhor que já vi."));

            // Colocando os vídeos em uma lista geral
            List<Video> listaVideos = new List<Video> { video1, video2, video3 };

            Console.WriteLine("===SISTEMA DE MONITORAMENTO DO YOUTUBE===\n");

            foreach (Video video in listaVideos)
            {
                Console.WriteLine($"Título: {video.Titulo}");
                Console.WriteLine($"Autor: {video.Autor}");
                Console.WriteLine($"Duração: {video.DuracaoSegundos} segundos");
                Console.WriteLine($"Total de Comentários: {video.ObterQuantidadeComentarios()}");
                Console.WriteLine("Comentários deixados:");

                foreach (Comentario com in video.Comentarios)
                {
                    Console.WriteLine($" - [{com.Autor}]: {com.Texto}");
                }

                Console.WriteLine(new string('-',50));
            }

            Console.ReadLine();

        }
    }

}