using System;

namespace AtividadesIntrospeccao
{
    public class AtividadeRespiracao : Atividade
    {
        public AtividadeRespiracao() : base(
            "Atividade de respiração",
            "Esta atividade ajudará você a relaixar, inspirando e expirando lentamente. Limpe sua mente concentre-se na sua respiração.")

        {

        }

        public override void Executar()
        {
            ExibirMensagemInicial();

            int tempoTotal = GetDuracao();

            int tempoDecorrido = 0;

            int tempoCiclo = 5;

            while (tempoDecorrido < tempoTotal)
            {
                Console.Write("Inspire... ");

                int tempoRestanteInspirar = Math.Min(tempoCiclo, tempoTotal - tempoDecorrido);
                ExibirContagemRegressiva(tempoRestanteInspirar);
                tempoDecorrido += tempoRestanteInspirar;
                Console.WriteLine();

                if (tempoDecorrido >= tempoTotal)
                    break;

                Console.Write("Expire... ");
                int tempoRestanteExpirar = Math.Min(tempoCiclo, tempoTotal - tempoDecorrido);
                ExibirContagemRegressiva(tempoRestanteExpirar);
                tempoDecorrido += tempoRestanteExpirar;
                Console.WriteLine();
            }

            ExibirMensagemFinal();
        }
    }
}