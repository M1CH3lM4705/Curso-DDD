using System;
using System.Collections.Generic;
using System.Linq;
using Curso_DDD.Exercicio7;

namespace Curso_DDD.Exercicio6
{
    public class CriadorDeNotaFiscal
    {
        public string RazaoSocial {get; private set;}
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data {get; private set;} = DateTime.Now;

        private double ValorTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        private IList<AcaoAposGerarNota> todasAcoesASeremExecutadas = new List<AcaoAposGerarNota>();

        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, impostos, todosItens, Observacoes);
            
            todasAcoesASeremExecutadas.ToList().ForEach(acao => acao.Executa(nf));

            return nf;
        }

        public void AdicionaAcao(AcaoAposGerarNota novaAcao)
        {
            this.todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public CriadorDeNotaFiscal ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscal ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;

        }

        public CriadorDeNotaFiscal ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;

        }

        public CriadorDeNotaFiscal NaData(DateTime data)
        {
            Data = data;
            return this;

        }

        public CriadorDeNotaFiscal ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
    }
}