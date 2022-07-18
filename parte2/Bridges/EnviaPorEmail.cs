using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_DDD.parte2.Bridges
{
    class EnviaPorEmail : IEnviador
    {
        public void Enviar(IMensagem mensagem)
        {
            Console.WriteLine("Enviando a mensagem por email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}