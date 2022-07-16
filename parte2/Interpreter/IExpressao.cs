using Curso_DDD.parte2.Visitor;

namespace Curso_DDD.parte2.Interpreter
{
    interface IExpressao
    {
         int Avalia();
         void Aceita(IVisitor impressora);
    }
}