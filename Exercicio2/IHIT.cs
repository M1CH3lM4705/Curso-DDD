using System.Linq;
using Curso_DDD;
using Curso_DDD.Exercicio2;

public class IHIT : TemplateMethodImposto
{
    public IHIT(Imposto outroImposto) : base(outroImposto)
    {
        
    }
    public IHIT() : base()
    {
        
    }
    public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
    {
        return TemMaisDeDoisItensMesmoNome(orcamento);
    }

    public override double MaximaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * 0.13 + 100 + calculoDoOutroImposto(orcamento);
    }

    public override double MinimaTaxacao(Orcamento orcamento)
    {
        return orcamento.Valor * (0.01 * orcamento.Itens.Count) + calculoDoOutroImposto(orcamento); 
    }

    private bool TemMaisDeDoisItensMesmoNome(Orcamento orcamento){
        var result = orcamento.Itens.GroupBy(i => i.Nome)
            .Where(i => i.Count() > 1)
            .Select(i => i.Key)
            .ToList();

        return result.Count > 2;
    }
}
