namespace Exercicio3
{
    public class Honda : IMontadora
    {
        public string Cor => "Vermelho";

        public string Modelo()
        {
            return "Honda Civic 2020";
        }
    }
}
