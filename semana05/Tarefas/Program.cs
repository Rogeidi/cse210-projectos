using System;

class Program
{
    static void Main(string[] args)
    {
        Tarefa tarefaSimples = new Tarefa("Samuel Silva", "Multiplicação");
        Console.WriteLine(tarefaSimples.ObterResumo());
        Console.WriteLine();

        TarefaDeMatematica contaMat = new TarefaDeMatematica("Roberto Rodriguez", "Frações", "7.3", "8-19");
        Console.WriteLine(contaMat.ObterResumo());
        Console.WriteLine(contaMat.ObterListaDeTarefas());
        Console.WriteLine();
        
        TarefaDeRedacao textoRed = new TarefaDeRedacao("Maria Antunes", "História da Europa", "As Causas da Segunda Gerra Mundial");
        Console.WriteLine(textoRed.ObterResumo());
        Console.WriteLine(textoRed.ObterInformacoesDaRedacao());
    }
}