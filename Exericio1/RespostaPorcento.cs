using System;

namespace Curso_DDD.Exericio1
{
    public class RespostaPorcento : IResposta
    {
        public IResposta OutraResposta { get; set; }

        public void Responde(Requisicao req, Conta conta)
        {
            if(req.Formato == Formato.PORCENTO){
                Console.WriteLine(conta.Nome + "%" + conta.Saldo);
            }else{
                OutraResposta.Responde(req, conta);
            }
        }
    }
}