namespace Curso_DDD.Exercicio6
{
    public class ItemDaNota
    {
        public ItemDaNota(string nome, double valor) 
        {
            Nome = nome;
            Valor = valor;
               
        }
        public string Nome { get; private set; }
        public double Valor { get; private set; }
    }
}