using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4_Resolucao
{
    public class LancheNatural : CriadorLanche
    {
        public LancheNatural()
        {
            lanche = new Lanche("Lanche Natural - Vegetariano");
        }
        public override void AddPao()
        {
            lanche["pao"] = "Integral com 5 grãos";
        }
        public override void AddRecheio()
        {
            lanche["recheio"] = "Hamburger vegetal especial";
        }
        public override void AddVegetais()
        {
            lanche["vegetais"] = "Alface, tomate, cebola";
        }
        public override void AddCondimentos()
        {
            lanche["condimentos"] = "molho de ervas";
        }
    }
}
