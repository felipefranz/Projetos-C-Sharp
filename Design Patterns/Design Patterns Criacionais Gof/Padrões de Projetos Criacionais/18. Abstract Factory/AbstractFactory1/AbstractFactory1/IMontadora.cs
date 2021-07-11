namespace AbstractFactory1
{
    interface IMontadora
    {
        ISuv CriarSuv();
        ISedan CriarSedan();
    }
}
