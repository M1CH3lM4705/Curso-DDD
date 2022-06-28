using System.Collections.Generic;
using System.Linq;
using Curso_DDD.Exericio1;
using Curso_DDD.Exercicio3;


namespace Curso_DDD.Exercicio3
{
    public class ContaSaldoMenorQue100 : Filtro
    {
        public ContaSaldoMenorQue100(Filtro outroFiltro) : base(outroFiltro)
        {
            
        }

        public ContaSaldoMenorQue100() : base(){}

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtro = new List<Conta>();
            foreach (Conta c in contas)
            {
                if(c.Saldo < 100) filtro.Add(c);
            }
            foreach(Conta c in Proximo(contas))
            {
                filtro.Add(c);
            }
           return filtro;
        }
    }
}