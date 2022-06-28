using System;
using Curso_DDD.Exercicio6;

namespace Curso_DDD.Exercicio7
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Salvo no banco.");
        }
    }
}