using Curso_DDD.Exercicio6;

namespace Curso_DDD.Exercicio7
{
    public class Multiplicador
    {
        public Multiplicador(double fator) 
        {
            this.Fator = fator;
               
        }

        public double Fator { get; private set; }

        public void Executa(NotaFiscal nf)
        {
            nf.ValorBruto *= Fator;
        }
    }
}