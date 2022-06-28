using System;
using Curso_DDD.Exercicio6;

namespace Curso_DDD.Exercicio7
{
    public class EnviadorDeSms : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviar Sms");
        }
    }
}