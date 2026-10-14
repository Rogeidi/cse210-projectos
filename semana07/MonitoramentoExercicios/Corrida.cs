namespace AcademiaApp
{
    public class Corrida : Atividade
    {
        private double _distanciaKm;
        public Corrida(string data, double duracaoEmMinutos, double distanciaKm) : base(data, duracaoEmMinutos)
        {
            _distanciaKm = distanciaKm;
        }

        public override double ObterDistancia() => _distanciaKm;
        public override double ObterVelocidade() => (_distanciaKm / DuracaoEmMinutos) * 60;
        public override double ObterRitmo() => DuracaoEmMinutos / _distanciaKm;
        
    }
}