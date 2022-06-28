namespace Curso_DDD
{
    public abstract class Imposto
    {
        private readonly Imposto OutroImposto;
        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {
            OutroImposto = null;
        }
        public abstract double Calcula(Orcamento orcamento);
        protected double calculoDoOutroImposto(Orcamento orcamento)
        {
            if(OutroImposto == null) return 0;
            return OutroImposto.Calcula(orcamento);
        }   
    }
}