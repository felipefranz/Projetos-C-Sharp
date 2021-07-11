namespace AbstractFactory1
{
    class Cliente
    {
        ISuv suv;
        ISedan sedan;

        public Cliente(IMontadora factory)
        {
            suv = factory.CriarSuv();
            sedan = factory.CriarSedan();
        }

        public string GetSuvDetalhes()
        {
            return suv.ExibeDetalhes();
        }

        public string GetSedanDetalhes()
        {
            return sedan.ExibeDetalhes();
        }
    }
}
