using Curso_DDD.Exercicio4;
using Curso_DDD;
using System;

namespace Curso_DDD.Exercicio4
{
    public class EmAprovacao : EstadoAtualOrcamento
    {
        public EmAprovacao()
        {
            DescontoAplicado = 1;
        }
        public int DescontoAplicado {get; set;}
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if(DescontoAplicado > 1) throw new Exception("O Desconto Já foi aplicado!");
            
            orcamento.Valor -= orcamento.Valor * 0.05;
            DescontoAplicado += 1;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovação não podem ir para finalizado diretamente");
        }
    }
}