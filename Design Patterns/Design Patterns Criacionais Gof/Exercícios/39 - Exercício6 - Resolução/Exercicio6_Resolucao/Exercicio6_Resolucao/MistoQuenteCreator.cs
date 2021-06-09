namespace Exercicio6_Resolucao
{
    public class MistoQuenteCreator : LancheCreator
    {
        protected override Lanche CriaLanche()
        {
            return new MistoQuente();
        }
    }
}
