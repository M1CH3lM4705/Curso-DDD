using System;

namespace Curso_DDD.Exericio1
{
    public class RespostaFinalSemFormato : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            Console.WriteLine("Fim Da corrente");
        }
    }
}