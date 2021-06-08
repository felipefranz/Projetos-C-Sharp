using System;

namespace SimpleFactory
{
    class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Nome = "Mussarela";
        }
        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} Assando por {tempo} min.");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome} ");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando pizza de {Nome} ");
        }
    }
}
