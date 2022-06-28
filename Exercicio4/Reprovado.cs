using Curso_DDD.Exercicio4;
using Curso_DDD;
using System;

namespace Curso_DDD.Exercicio4
{
    public class Reprovado : EstadoAtualOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos reprovados não recebem desconto extra");
        }

         public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de reprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}