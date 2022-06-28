// using System;
// using Curso_DDD.Exercicio2;

// namespace Curso_DDD
// {
//     public class TestaCorrente
//     {
//         static void Main(string[] args)
//         {
//             var orcamento = new Orcamento(250.0);

//             TemplateMethodImposto Icpp = new ICPP(new IHIT());
//             TemplateMethodImposto Ikcv = new IKCV(new IHIT());

//             Icpp.Calcula(orcamento);
//             Ikcv.Calcula(orcamento);

//             Console.WriteLine(Icpp);
//             Console.WriteLine(Ikcv);
//         }
//     }
// }