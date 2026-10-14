
namespace AcademiaApp
{
    public class Natacao : Atividade
    {
        private int _numeroDeVoltas;

        public Natacao(string data, double duracaoEmMinutos, int numeroDeVoltas) : base (data, duracaoEmMinutos)
        {
            _numeroDeVoltas = numeroDeVoltas;
        }

        public override double ObterDistancia() => (_numeroDeVoltas * 50) / 1000.0;

        public override double ObterVelocidade() => (ObterDistancia() / DuracaoEmMinutos) * 60;

        public override double ObterRitmo() => DuracaoEmMinutos / ObterDistancia();
    }

    
}