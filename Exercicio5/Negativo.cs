using Curso_DDD.Exericio1;
using System;

namespace Curso_DDD.Exercicio5
{
    public class Negativo : IEstadoDaConta
    {
        public void EfetuarDeposito(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if(conta.Saldo > 0) conta.EstadoDaConta = new Positivo();
        }

        public void EfetuarSaque(Conta conta, double valor)
        {
            throw new Exception("Sua conta está negativa");
        }
    }
}