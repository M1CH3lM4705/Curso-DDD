using Curso_DDD.Exercicio3;
using System.Collections.Generic;
using Curso_DDD.Exericio1;
using System;

public class ContaDataDeAberturaRecorrente : Filtro
{
    public ContaDataDeAberturaRecorrente(Filtro outroFiltro) : base(outroFiltro)
    {}

    public ContaDataDeAberturaRecorrente() : base(){}

    public override IList<Conta> Filtra(IList<Conta> contas)
    {
        IList<Conta> filtro = new List<Conta>();
        foreach(Conta c in contas)
        {
            if(c.DataAbertura.Month == DateTime.Now.Month &&
               c.DataAbertura.Year == DateTime.Now.Year)
               {
                   filtro.Add(c);
               }
        }
        foreach(Conta c in Proximo(contas))
        {
            filtro.Add(c);
        }

        return filtro;
    }
}