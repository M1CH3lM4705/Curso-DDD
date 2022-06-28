using System.Collections.Generic;
using Curso_DDD.Exericio1;
using Curso_DDD.Exercicio3;
using System.Linq;
using System.Linq.Expressions;

namespace Curso_DDD.Exercicio3
{
    public class ContaSaldoMaiorQue500 : Filtro
    {
        public ContaSaldoMaiorQue500(Filtro filtro) : base(filtro)
        { }

        public ContaSaldoMaiorQue500() : base(){}
        
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            return contas;
        }
    }
}