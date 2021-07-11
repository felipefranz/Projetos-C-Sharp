namespace Builder_Phones
{
    class Fabricante
    {
        public void Construir(ICelularBuilder celularBuilder)
        {
            celularBuilder.BuildBateria();
            celularBuilder.BuildSO();
            celularBuilder.BuildTela();
        }
    }
}
