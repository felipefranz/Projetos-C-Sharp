using System;

namespace Exercicio3_Resolucao
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
