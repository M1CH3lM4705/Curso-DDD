using System.Collections.Generic;
using Curso_DDD.Exercicio4;

namespace Curso_DDD
{
    public class Orcamento
    {
        public EstadoAtualOrcamento  EstadoAtual {get; set;} 
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new EmAprovacao();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}