using System.Collections.Generic;

namespace Exercicio2_Resolucao
{
    class Univ2Medicina : IAluno
    {
        public List<string> Cursos()
        {
            return new List<string> { "Fisiologia", "Anatomia", "Histologia" };
        }
    }
}
