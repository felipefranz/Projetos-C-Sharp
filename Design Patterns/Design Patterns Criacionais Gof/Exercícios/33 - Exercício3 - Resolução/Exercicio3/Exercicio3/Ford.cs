using System;

namespace Exercicio3
{
    public class Ford : IMontadora
    {
        public string Cor => "Branco";

        public string Modelo()
        {
            return "Ford KA 1.0 Turbo 2020";
        }
    }
}
