using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio4_Resolucao
{
    public class LancheNormal : CriadorLanche
    {
        public LancheNormal()
        {
            lanche = new Lanche("Lanche Normal - Hambúrger Especial");
        }
        public override void AddPao()
        {
            lanche["pao"] = "de Hamburger com gergelim";
        }
        public override void AddRecheio()
        {
            lanche["recheio"] = "Filé Mignon de 120g";
        }
        public override void AddVegetais()
        {
            lanche["vegetais"] = "Alface, tomate, cebola, rúcula";
        }
        public override void AddCondimentos()
        {
            lanche["condimentos"] = "molho de mostarda com mel";
        }
    }
}
