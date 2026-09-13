using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _registros = new List<Registro>();
    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void ExibirTodos()
    {
        if (_registros.Count == 0)
        {
            Console.WriteLine("O diário está vazio.");
            return;
        }
        foreach (Registro reg in _registros)
        {
            reg.Exibir();
        }
    }

    public void SalvarNoArquivo(string arquivo)
    {
        using (StreamWriter writer = new StreamWriter(arquivo))
        {
            foreach (Registro reg in _registros)
            {
                writer.WriteLine($"{reg._data}|{reg._textoPergunta}|{reg._textoResposta}");

            }
        }
        Console.WriteLine("Diário salvo com sucesso!");
    }

    public void CarregadorDoArquivo(string arquivo)
    {
        if (!File.Exists(arquivo))
        {
            Console.WriteLine("Arquivo não encontrado");
            return;
        }

        _registros.Clear();

        string[] linhas = File.ReadAllLines(arquivo);
        foreach (string linha in linhas)
        {
            string[] partes = linha.Split('|');
            if (partes.Length == 3)
            {
                Registro reg = new Registro();
                reg._data = partes[0];
                reg._textoPergunta = partes[1];
                reg._textoResposta = partes[2];

                _registros.Add(reg);
            }
        }
        Console.WriteLine("Diário carregado com sucesso");
    }
}