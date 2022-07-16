using Curso_DDD.parte2.Visitor;

namespace Curso_DDD.parte2.Interpreter
{
    class Divisao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public void Aceita(IVisitor impressora)
        {
            throw new System.NotImplementedException();
        }

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();

            return valorEsquerda / valorDireita;
        }
    }
}