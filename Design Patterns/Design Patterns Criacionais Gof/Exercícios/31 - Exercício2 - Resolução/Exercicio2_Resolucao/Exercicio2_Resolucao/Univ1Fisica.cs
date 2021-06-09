using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio2_Resolucao
{
    public class Univ1Fisica : IAluno
    {
        public List<string> Cursos()
        {
            return new List<string> { "Física Quântica", "Física Básica", "Física Aplicada" };
        }
    }
}
