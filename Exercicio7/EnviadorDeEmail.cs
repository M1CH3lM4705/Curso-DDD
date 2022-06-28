using Curso_DDD.Exercicio6;
using System;

namespace Curso_DDD.Exercicio7
{
    public class EnviadorDeEmail : AcaoAposGerarNota;
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviar Email!");
        }
    }
}