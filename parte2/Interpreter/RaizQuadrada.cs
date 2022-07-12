using System;
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

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            return ((int)Math.Sqrt(valorEsquerda));
        }
    }
}