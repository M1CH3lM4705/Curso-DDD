using System;

namespace Curso_DDD.parte2.Bridges
{
    class MensagemCliente : IMensagem
    {
        public string Nome { get; private set; }
        public IEnviador Enviador { get; set; }
        public MensagemCliente(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            Enviador.Enviar(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem para o cliente {0}", Nome);
        }
    }
}