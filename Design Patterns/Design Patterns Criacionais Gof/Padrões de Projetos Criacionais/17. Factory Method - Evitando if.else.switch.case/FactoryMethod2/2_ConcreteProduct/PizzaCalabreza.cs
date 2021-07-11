namespace FactoryMethod2
{
    //ConcreteProduct
    public class PizzaCalabreza : Pizza
    {
        private readonly string _nomePizza;
        public PizzaCalabreza()
        {
            _nomePizza = "Pizza Calabreza";
            Ingredientes.Add("Fatias de calabreza especial");
            Ingredientes.Add("Queijo parmessão italiano tradicional");
        }
        public override string Nome { get => _nomePizza; }
    }
}
