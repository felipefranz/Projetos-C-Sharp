namespace FactoryMethod
{
    public class RJPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("M"))
            {
                return new RJPizzaMussarela();
            }
            if (tipo.Equals("C"))
            {
                return new RJPizzaCalabresa();
            }
            else return null;
        }
    }
}
