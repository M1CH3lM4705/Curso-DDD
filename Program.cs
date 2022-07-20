using System;
using System.Collections.Generic;
using Curso_DDD.Exercicio6;
using Curso_DDD.parte2.Bridges;
using Curso_DDD.parte2.Command;
using Curso_DDD.parte2.FlyWeight;
using Curso_DDD.parte2.Interpreter;
using Curso_DDD.parte2.Memento;
using Curso_DDD.parte2.Visitor;

namespace Curso_DDD
{
    class Program
    {
        static void Main(string[] args)
        {
            // IDesconto d1 = new DescontoPorCincoItens();
            // IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            // IDesconto d3 = new DescontoPorVendaCasada();
            // IDesconto d4 = new SemDesconto();

            // d1.Proximo = d2;
            // d2.Proximo = d3;
            // d3.Proximo = d4;

            // Orcamento orcamento = new Orcamento(500.0);

            // double desconto = d1.Desconta(orcamento);
            // Console.WriteLine(desconto);

            // CriadorDeNotaFiscal criador = new CriadorDeNotaFiscal();
            // criador.AdicionaAcao(new EnviadorDeEmail());
            // criador.AdicionaAcao(new NotaFiscalDao());
            // criador.AdicionaAcao(new EnviadorDeSms());
            // criador.AdicionaAcao(new Multiplicador(100.0));

            // criador.ParaEmpresa("Caelum")
            //     .ComCnpj("123.456.789/0001-10")
            //     .ComItem(new ItemDaNota("item 1", 100.0))
            //     .ComItem(new ItemDaNota("item 2", 200.0))
            //     .ComItem(new ItemDaNota("item 3", 300.0))
            //     .ComObservacoes("entregar nf pessoalmente")
            //     .NaDataAtual();

            // NotaFiscal nf = criador.Constroi();

            // Console.WriteLine(nf.ValorBruto);

            // NotasMusicais notas = new NotasMusicais();

            // IList<INota> musica = new List<INota>()
            // {
            //     notas.Pega("do"),
            //     notas.Pega("re"),
            //     notas.Pega("mi"),
            //     notas.Pega("fa"),   
            //     notas.Pega("fa"),   
            //     notas.Pega("fa"),   
            // };

            // Piano piano = new Piano();
            // piano.Toca(musica);

            // Historico historico = new Historico();
            // Contrato c = new Contrato(DateTime.Now, "Michel", TipoContrato.Novo);
            // historico.Adiciona(c.SalvaEstado());

            // c.Avanca();

            // historico.Adiciona(c.SalvaEstado());

            // c.Avanca();
            // historico.Adiciona(c.SalvaEstado());

            // Console.WriteLine(historico.Pega(2).Contrato.Tipo);

            // Console.ReadKey();

            // IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            // IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            // IExpressao soma = new Soma(esquerda, direita);

            // Console.WriteLine(soma.Avalia());
            // Impressora impressora = new Impressora();
            // soma.Aceita(impressora);

            // IMensagem mensagem = new MensagemAdministrativa("Michel");
            // IEnviador enviador = new EnviaPorEmail();
            // mensagem.Enviador = enviador;
            // mensagem.Envia();

            FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Michel", 100);
            Pedido pedido2 = new Pedido("Michel", 50);
            
            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();
        }
    }
}
