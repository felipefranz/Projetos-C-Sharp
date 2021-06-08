using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory1
{
    class HondaCRV : ISuv
    {
        public string ExibeDetalhes()
        {
            return "Honda CR-V Turbo 190cv\nAno 2020";
        }
    }
}
