using System;

namespace MetasEternas
{
    public class MetaEterna : Meta
    {
        public MetaEterna(string nome, string descricao, int pontos) 
            : base(nome, descricao, pontos)
        {
           
        }

        
        public override int RegistrarEvento()
        {
            return _pontos;
        }

        
        public override string ObterDetalhesAlvo()
        {
            return $"[ ] {_nome} ({_descricao})";
        }

        public override string ObterStringSalvamento()
        {
            return $"MetaEterna|{_nome}|{_descricao}|{_pontos}|{_isConcluida}";
        }
    }
}