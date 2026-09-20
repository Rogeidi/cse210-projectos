using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string textoCompleto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavrasSeparadas = textoCompleto.Split(' ');

        foreach (string palavraTexto in palavrasSeparadas)
        {
            if (!string.IsNullOrWhiteSpace(palavraTexto))
            {
                _palavras.Add(new Palavra(palavraTexto));
            }

        }

    }
    public void EsconderPalavrasAleatorias(int quantidadeParaEsconder)
    {
        Random numeroAleatorio = new Random();
        int palavrasEscondidasNestaRodada = 0;

        int palavrasVisiveis = 0;
        foreach (Palavra p in _palavras)
        {
            if (!p.EstaEscondida())
            {
                palavrasVisiveis++;
            }
        }

        int metaEsconder = Math.Min(quantidadeParaEsconder, palavrasVisiveis);


        while (palavrasEscondidasNestaRodada < metaEsconder)
        {
            int indiceSorteado = numeroAleatorio.Next(_palavras.Count);

            if (!_palavras[indiceSorteado].EstaEscondida())
            {
                _palavras[indiceSorteado].Esconder();
                palavrasEscondidasNestaRodada++;
            }
        }
    }

    public string ObterTextoExibicao()
    {
        List<string> palavrasParaExibir = new List<string>();

        foreach (Palavra palavra in _palavras)
        {
            palavrasParaExibir.Add(palavra.ObterTextoExibicao());
        }

        string textoFormatado = string.Join(" ", palavrasParaExibir);

        return $"{_referencia.ObterTextoExibicao()}\n{textoFormatado}";
    }

    public bool CompletamenteEscondida()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaEscondida())
            {
                return false;
            }
        }
        return true;
    }
}