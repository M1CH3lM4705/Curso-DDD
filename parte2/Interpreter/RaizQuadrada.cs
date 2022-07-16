using System;
using Curso_DDD.parte2.Visitor;

namespace Curso_DDD.parte2.Interpreter
{
    class RaizQuadrada : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public RaizQuadrada(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public void Aceita(IVisitor impressora)
        {
            throw new NotImplementedException();
        }

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            return ((int)Math.Sqrt(valorEsquerda));
        }
    }
}