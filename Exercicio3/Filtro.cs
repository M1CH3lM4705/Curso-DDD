using System.Collections.Generic;
using Curso_DDD.Exericio1;

namespace Curso_DDD.Exercicio3
{
    public abstract class Filtro
    {
        private readonly Filtro _filtro;
        public Filtro(Filtro filtro)
        {
            _filtro = filtro;
        }

        public Filtro()
        {
           
        }
        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if(_filtro != null) return _filtro.Filtra(contas);
            else return new List<Conta>();
        }
    }
}