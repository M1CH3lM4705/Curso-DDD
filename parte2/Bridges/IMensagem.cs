
namespace Curso_DDD.parte2.Bridges
{
    interface IMensagem
    {
        IEnviador Enviador { get; set;}
        void Envia();
        string Formata();    
    }
}