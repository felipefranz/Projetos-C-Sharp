namespace FactoryMethod
{
    public class RJPizzaCalabresa : Pizza
    {
        public RJPizzaCalabresa()
        {
            Nome = "Pizza de calabreza Carioca com cebola";
            massa = "Massa tradicional carioca";
            molho = "Molho de tomate italiano carioca";
            ingredientes.Add("Fatias de calabreza especial");
            ingredientes.Add("Queijo parmessão italiano tradicional");
        }
    }
}
