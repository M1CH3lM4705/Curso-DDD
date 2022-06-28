using Curso_DDD.Exercicio4;
using Curso_DDD;
using System;

namespace Curso_DDD.Exercicio4
{
    public class Finalizado : EstadoAtualOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

         public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Não posso mudar mais, já estou finalizado!");
        }
    }
}