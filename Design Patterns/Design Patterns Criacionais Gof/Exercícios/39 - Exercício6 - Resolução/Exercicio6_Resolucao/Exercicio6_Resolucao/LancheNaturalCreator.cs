namespace Exercicio6_Resolucao
{
    public class LancheNaturalCreator : LancheCreator
    {
        protected override Lanche CriaLanche()
        {
            return new LancheNatural();
        }
    }
}
