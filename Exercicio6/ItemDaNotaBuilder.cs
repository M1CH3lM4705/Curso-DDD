namespace Curso_DDD.Exercicio6
{
    public class ItemDaNotaBuilder
    {
        public string NomeDoItem { get; private set; }
        public double ValorDoItem { get; private set; }

        public ItemDaNotaBuilder DescricaoItem(string nomeItem)
        {
            NomeDoItem = nomeItem;
            return this;
        }

        public ItemDaNotaBuilder ValorItem(double valorItem)
        {
            ValorDoItem = valorItem;
            return this;
        }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(NomeDoItem, ValorDoItem);
        }
    }
}