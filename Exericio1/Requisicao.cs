using Curso_DDD.Exericio1;

public class Requisicao
{
    public Formato Formato { get; private set; }
    public Requisicao(Formato formato)
    {
        Formato = formato;    
    }
}