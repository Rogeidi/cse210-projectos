using System;

namespace MetasEternas
{
    public class MetaSimples : Meta
    {
        public MetaSimples(string nome, string descricao, int pontos) : base (nome, descricao, pontos)
        {
            
        }
        public override int RegistrarEvento()
        {
            if (_isConcluida)
            {
                Console.WriteLine("Esta meta já foi concluída anteriormente!");
                return 0;
            }

            _isConcluida = true;
            return _pontos;
        }

        public override string ObterDetalhesAlvo()
        {
            string status = _isConcluida ? "[X]" : "[ ]";
            return $"{status} {_nome} ({_descricao})";
        }

        public override string ObterStringSalvamento()
        {
            return $"MetaSimples|{_nome}|{_descricao}|{_pontos}|{_isConcluida}";
        }
    }
}