namespace FactoryMethod2
{
    //ConcreteProduct
    public class PizzaQuatroQueijos : Pizza
    {
        private readonly string _nomePizza;
        public PizzaQuatroQueijos()
        {
            _nomePizza = "Pizza Quatro Queijos";
            Ingredientes.Add("Queijo Parmessão");
            Ingredientes.Add("Queijo Gorgonzola");
            Ingredientes.Add("Queijo Brie");
            Ingredientes.Add("Queijo Provolone");
        }
        public override string Nome { get => _nomePizza; }
    }
}
