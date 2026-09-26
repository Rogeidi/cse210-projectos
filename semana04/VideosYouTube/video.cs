using System;
using System.Collections.Generic;

namespace MonitoramentoYoutube
{
    public class Video
    {
        private string _titulo;
        private string _autor;
        private int _duracaoSegundos;
        private List<Comentario> _comentarios;

        public string Titulo => _titulo;
        public string Autor => _autor;
        public int DuracaoSegundos => _duracaoSegundos;
        public List<Comentario> Comentarios => _comentarios;

        public Video(string titulo, string autor, int duracaoSegundos)
        {
            _titulo = titulo;
            _autor = autor;
            _duracaoSegundos = duracaoSegundos;
            _comentarios = new List<Comentario>();
        }

        public void AdicionarComentario(Comentario comentario)
        {
            _comentarios.Add(comentario);
        }

        public int ObterQuantidadeComentarios()
        {
            return _comentarios.Count;
        }

    }
}