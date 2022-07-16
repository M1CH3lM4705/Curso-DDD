using Curso_DDD.parte2.Interpreter;

namespace Curso_DDD.parte2.Visitor
{
    interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero soma);

    }
}