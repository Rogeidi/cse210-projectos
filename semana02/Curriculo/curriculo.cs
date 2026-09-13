using System;

public class Curriculo
{
    public string _nome;
    public List<Emprego> _empregos = new List<Emprego>();
    public void ExibirCurriculo()
    {
        Console.WriteLine($"Nome: {_nome}");
        Console.WriteLine("Empregos:");

        foreach (Emprego emprego in _empregos)
        {
            emprego.ExibirInformacoes();
        }
    }


}