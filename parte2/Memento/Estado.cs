namespace Curso_DDD.parte2.Memento
{
    class Estado
    {
        public Contrato Contrato { get; private set; }
        
        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }
    }
}