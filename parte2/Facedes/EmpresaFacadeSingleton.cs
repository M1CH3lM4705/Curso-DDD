using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_DDD.parte2.Facedes
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade facade = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get{
                return facade;
            }
        }
    }
}