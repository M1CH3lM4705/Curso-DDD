using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_DDD.parte2.Command
{
    public class FinalizaPedido : IComando
    {
        private Pedido pedido;
        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do cliente {0}", pedido.Cliente);

            pedido.Finaliza();
        }
    }
}