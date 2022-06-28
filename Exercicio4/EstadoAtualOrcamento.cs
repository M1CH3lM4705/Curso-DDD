using Curso_DDD;

namespace Curso_DDD.Exercicio4
{
    public interface EstadoAtualOrcamento
    {
         void AplicaDescontoExtra(Orcamento orcamento);

         void Aprova(Orcamento orcamento);
         void Reprova(Orcamento orcamento);
         void Finaliza(Orcamento orcamento);
    }
}