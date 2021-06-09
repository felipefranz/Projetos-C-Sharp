namespace Exercicio2_Resolucao
{
    public class Univ2Factory : AlunoFactory
    {
        public override IAluno GetAluno(string alunoDepartamento)
        {
            if (alunoDepartamento.Equals("MEDICINA"))
                return new Univ2Medicina();
            else if (alunoDepartamento.Equals("BIOLOGIA"))
                return new Univ2Biologia();
            else
                return null;
        }
    }
}
