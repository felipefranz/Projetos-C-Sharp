using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio6_Resolucao
{
    public class CachorroQuenteCreator : LancheCreator
    {
        protected override Lanche CriaLanche()
        {
            return new CachorroQuente();
        }
    }
}
