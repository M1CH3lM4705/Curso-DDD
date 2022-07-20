using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_DDD.parte2.Facedes
{
    public class EmpresaFacade
    {
        public Cliente BuscaCliente(string cpf)
        {
            return new ClienteDao().BuscarPorCpf(cpf);
        }

        public Fatura CriaFatura(Cliente cliente, double valor)
        {
            return new Fatura(cliente, valor);
        }

        public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        {
            Cobranca cobranca = new Cobranca(tipo, fatura);
            cobranca.Emite();
        }

        public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        {
            FazContato
        }
    }
}