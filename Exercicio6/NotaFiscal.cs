using System;
using System.Collections.Generic;
namespace Curso_DDD.Exercicio6
{
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, 
            double valorBruto, double impostos, IList<ItemDaNota> itens, string observacoes) 
        {
                this.RazaoSocial = razaoSocial;
                this.Cnpj = cnpj;
                this.DataDeEmissao = dataDeEmissao;
                this.ValorBruto = valorBruto;
                this.Impostos = impostos;
                Itens = itens;
                this.Observacoes = observacoes;
               
        }

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string Observacoes { get; set; }

    }
}