using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class SPPizzaCalabresa : Pizza
    {
        public SPPizzaCalabresa()
        {
            Nome = "Pizza de calabreza Paulista com muita calabreza";
            massa = "Massa fina crocante";
            molho = "Molho de tomate italiano";
            ingredientes.Add("Fatias de calabreza defumada especial");
            ingredientes.Add("Queijo parmessão italiano tradicional");
        }
    }
}
