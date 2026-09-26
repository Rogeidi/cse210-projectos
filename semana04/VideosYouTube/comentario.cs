using System;

namespace MonitoramentoYoutube
{
    public class Comentario
    {
        private string _autor;
        private string _texto;

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public string Texto
        {
            get { return _texto; }
            set { _texto = value; }
        }

        public Comentario(string autor, string texto)
        {
            _autor = autor;
            _texto = texto;
        }

    }
}