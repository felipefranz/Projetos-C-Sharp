namespace Exercicio6_Resolucao
{
    public class LancheNatural : Lanche
    {
        public override string GetCondimentos()
        {
            return "Azeite, maionese";
        }

        public override string GetPao()
        {
            return "Pão de forma integral";
        }

        public override string GetRecheio()
        {
            return "Alface, tomate, cenoura ralada, rúcula, pepino e cebola";
        }
    }
}
