using System;

namespace AcademiaApp
{
    public abstract class Atividade
    {
        private string _data;
        private double _duracaoEmMinutos;

        public Atividade(string data, double duracaoEmMinutos)
        {
            _data = data;
            _duracaoEmMinutos = duracaoEmMinutos;
        }

        protected double DuracaoEmMinutos => _duracaoEmMinutos;

        public abstract double ObterDistancia();
        public abstract double ObterVelocidade();
        public abstract double ObterRitmo();

        public string ObterResumo()
        {
            string tipoAtividade = this.GetType().Name;

            return  $"{_data} {tipoAtividade} ({_duracaoEmMinutos} min): " +
                    $"Distância: {ObterDistancia():F1} Km, " +
                    $"Velocidade: {ObterVelocidade():F1} Km/h, " +
                    $"Ritmo: {ObterRitmo():F2} min por Km";
        }


    }
}