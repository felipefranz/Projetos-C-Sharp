using System;

namespace FactoryMethod
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria;
            switch (local)
            {
                case "S":
                    pizzaria = new SPPizzaFactory();
                    break;
                case "R":
                    pizzaria = new RJPizzaFactory();
                    break;
                default:
                    throw new ApplicationException($"A pizzaria {local} não foi criada");
            }
            return pizzaria;
        }
    }
}
