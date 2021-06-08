using System;

namespace SimpleFactory
{
    class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza()
        {
            Nome = "Calabresa";
        }

        public override void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} Assar por {tempo} min.");
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
