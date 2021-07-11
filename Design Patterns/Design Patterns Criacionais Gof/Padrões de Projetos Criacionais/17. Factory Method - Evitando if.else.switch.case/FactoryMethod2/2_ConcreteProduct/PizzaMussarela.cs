namespace FactoryMethod2
{
    //ConcreteProduct
    public class PizzaMussarela : Pizza
    {
        private readonly string _nomePizza;
        public PizzaMussarela()
        {
            _nomePizza = "Pizza Mussarela";
            Ingredientes.Add("Queijo parmessão ralado");
            Ingredientes.Add("Molho de tomate e azeitonas");
        }
        public override string Nome { get => _nomePizza; }
    }
}
