namespace Curso_DDD.Exercicio2
{
    public abstract class TemplateMethodImposto : Imposto
    {
        protected TemplateMethodImposto(Imposto outroImposto) : base(outroImposto)
        {
        }
        public TemplateMethodImposto() : base(){}

        public override double Calcula(Orcamento orcamento)
        {
            if(DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }

        public abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        public abstract double MaximaTaxacao(Orcamento orcamento);
        public abstract double MinimaTaxacao(Orcamento orcamento);
    }
}