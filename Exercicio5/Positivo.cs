using Curso_DDD.Exericio1;

namespace Curso_DDD.Exercicio5
{
    public class Positivo : IEstadoDaConta
    {
        public void EfetuarDeposito(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void EfetuarSaque(Conta conta, double valor)
        {
            conta.Saldo -= valor;
        }
        
    }
}