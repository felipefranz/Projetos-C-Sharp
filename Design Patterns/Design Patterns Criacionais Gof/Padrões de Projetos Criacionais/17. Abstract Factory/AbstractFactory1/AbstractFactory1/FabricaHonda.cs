namespace AbstractFactory1
{
    class FabricaHonda : IMontadora
    {
        public ISedan CriarSedan()
        {
            return new HondaCivic();
        }

        public ISuv CriarSuv()
        {
            return new HondaCRV();
        }
    }
}
