using Curso_DDD.parte2.Visitor;

namespace Curso_DDD.parte2.Interpreter
{
    class Soma : IExpressao
    {
    
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public IExpressao Esquerda { get; private set; }
        internal IExpressao Direita { get; private set; }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            
            return valorEsquerda + valorDireita;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }
    }
}