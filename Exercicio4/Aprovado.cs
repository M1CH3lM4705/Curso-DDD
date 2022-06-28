using Curso_DDD.Exercicio4;
using Curso_DDD;
using System;

namespace Curso_DDD.Exercicio4
{
    public class Aprovado : EstadoAtualOrcamento
    {
        public Aprovado()
        {
            DescontoAplicado = 1;
        }

        public int DescontoAplicado {get; set;}
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if(DescontoAplicado > 1) throw new Exception("O Desconto ja foi aplicado");

            orcamento.Valor -= orcamento.Valor * 0.02;
            DescontoAplicado += 1;
        }

         public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em estado de aprovação");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento está em estado de aprovação e não pode ser reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}