using Curso_DDD.Exericio1;

namespace Curso_DDD.Exercicio5
{
    public interface IEstadoDaConta
    {
         void EfetuarSaque(Conta conta, double valor);
         void EfetuarDeposito(Conta conta, double valor);
    }
}