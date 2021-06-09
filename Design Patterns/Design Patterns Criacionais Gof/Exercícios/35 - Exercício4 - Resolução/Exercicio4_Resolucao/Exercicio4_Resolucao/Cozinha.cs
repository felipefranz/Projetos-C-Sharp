namespace Exercicio4_Resolucao
{
    public class Cozinha
    {
        public void MontaLanche(CriadorLanche criadorLanche)
        {
            criadorLanche.AddPao();
            criadorLanche.AddRecheio();
            criadorLanche.AddVegetais();
            criadorLanche.AddCondimentos();
        }
    }
}
