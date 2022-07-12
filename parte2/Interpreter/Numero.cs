namespace Curso_DDD.parte2.Interpreter
{
    public class Numero : IExpressao
    {
        private int numero;

        public Numero(int Numero)
        {
            this.numero = Numero;
        }

        public int Avalia()
        {
            return this.numero;
        }
    }
}