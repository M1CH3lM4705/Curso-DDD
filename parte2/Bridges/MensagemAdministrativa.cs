using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_DDD.parte2.Bridges
{
    class MensagemAdministrativa : IMensagem
    {
        public MensagemAdministrativa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
        public IEnviador Enviador { get; set; }
        public void Envia()
        {
            Enviador.Enviar(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o administrador {0}", Nome);
        }
    }
}