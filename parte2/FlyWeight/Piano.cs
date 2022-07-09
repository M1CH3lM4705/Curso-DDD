using System;
using System.Collections.Generic;

namespace Curso_DDD.parte2.FlyWeight
{
    class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach(var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}