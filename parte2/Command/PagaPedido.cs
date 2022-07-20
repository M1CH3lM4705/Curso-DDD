using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_DDD.parte2.Command
{
    public class PagaPedido : IComando
    {
        private Pedido pedido;
        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }
        public void Executa()
        {
            Console.WriteLine("Pagando o pedido do cliente {0}", pedido.Cliente);
            pedido.Paga();
        }
    }
}