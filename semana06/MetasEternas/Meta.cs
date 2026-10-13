using System;

namespace MetasEternas
{
    public abstract class Meta
    {
        protected string _nome;
        protected string _descricao;

        protected int _pontos;
        protected bool _isConcluida;

        public string Nome => _nome;
        public string Descricao => _descricao;
        public int Pontos => _pontos;
        public bool IsConcluida => _isConcluida;

        public Meta(string nome, string descricao, int pontos)
        {
            _nome = nome;
            _descricao = descricao;
            _pontos = pontos;
            _isConcluida = false;
        }

        public abstract int RegistrarEvento();

        public abstract string ObterDetalhesAlvo();

        public abstract string ObterStringSalvamento();


    }
}