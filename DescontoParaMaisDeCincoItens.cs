namespace Curso_DDD
{
    public class DescontoParaMaisDeCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return orcamento.Itens.Count > 5 ?
                orcamento.Valor * 0.10 : 
                Proximo.Desconta(orcamento);
        }
    }
}