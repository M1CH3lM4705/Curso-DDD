using System;
using Curso_DDD.Exercicio5;

namespace Curso_DDD.Exericio1
{
    public class Conta
    {
        public IEstadoDaConta EstadoDaConta {get; set;}
        public string Nome { get; private set; }
        public double Saldo { get; set; }
        public DateTime DataAbertura { get; private set; }

        public Conta(string nome, double saldo)
        {
            Nome = nome;
            Saldo = saldo;
            DataAbertura = DateTime.Now;
        }

        public void Sacar(double valor){
            EstadoDaConta.EfetuarSaque(this, valor);
        }

        public void Depositar(double valor)
        {
            EstadoDaConta.EfetuarDeposito(this, valor);
        }
    }
}