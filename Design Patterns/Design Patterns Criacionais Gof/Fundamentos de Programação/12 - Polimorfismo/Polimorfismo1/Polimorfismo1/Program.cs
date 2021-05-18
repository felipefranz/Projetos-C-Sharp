using System;
using System.Collections.Generic;

namespace Polimorfismo1
{
    class Program
    {
        static void Main(string[] args)
        {

            var figuras = new List<Figura>
            {
                new Circulo(),
                new Triangulo()
            };

            foreach(var figura in figuras)
            {
                figura.Desenhar();
            }

            Console.ReadLine();
        }
    }
}
