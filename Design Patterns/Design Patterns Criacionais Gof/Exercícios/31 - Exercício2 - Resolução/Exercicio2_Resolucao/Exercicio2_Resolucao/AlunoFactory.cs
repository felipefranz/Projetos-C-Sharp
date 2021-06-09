namespace Exercicio2_Resolucao
{
    public abstract class AlunoFactory
    {
        public abstract IAluno GetAluno(string alunoDepartamento);
        public static AlunoFactory CreateAlunoFactory(string alunoUniversidade)
        {
            if (alunoUniversidade.Equals("UNIV1"))
                return new Univ1Factory();
            else
                return new Univ2Factory();
        }
    }
}
