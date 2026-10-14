namespace AcademiaApp
{
    public class Ciclismo : Atividade
    {
        private double _velocidadeKmh;

        public Ciclismo(string data, double duracaoEmMinutos, double velocidadeKmh) : base(data,duracaoEmMinutos)
        {
            _velocidadeKmh = velocidadeKmh;
        }
        public override double ObterDistancia() => (_velocidadeKmh * DuracaoEmMinutos) / 60;
        public override double ObterVelocidade() => _velocidadeKmh;
        public override double ObterRitmo() => 60 / _velocidadeKmh;
    }
}