using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_DDD.parte2.Command
{
    public class FilaDeTrabalho
    {
        private IList<IComando> Comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            this.Comandos.Add(comando);
        }

        public void Processa()
        {
            foreach(var comando in this.Comandos)
            {
                comando.Executa();
            }
        }
    }
}