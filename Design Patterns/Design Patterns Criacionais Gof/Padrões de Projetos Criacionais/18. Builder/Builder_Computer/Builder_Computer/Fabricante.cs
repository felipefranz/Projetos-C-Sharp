namespace Builder_Computer
{
    class Fabricante
    {
        //Director
        public void Build(ComputadorBuilder computadorBuilder)
        {
            computadorBuilder.BuildDispositivos();
            computadorBuilder.BuildSO();
        }
    }
}
