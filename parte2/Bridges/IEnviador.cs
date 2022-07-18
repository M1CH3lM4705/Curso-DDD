using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_DDD.parte2.Bridges
{
    interface IEnviador
    {
        public void Enviar(IMensagem mensagem);
    }
}