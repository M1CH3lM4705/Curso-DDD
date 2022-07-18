using System;
using Curso_DDD.parte2.Interpreter;

namespace Curso_DDD.parte2.Visitor
{
    class Impressora : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write("+");
            soma.Esquerda.Aceita(this);
            soma.Direita.Aceita(this);
            Console.Write(")");

        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write("-");
            subtracao.Esquerda.Aceita(this);
            subtracao.Direita.Aceita(this);
            Console.Write(")");

        }
        
        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);

        }
        
             
    }
}