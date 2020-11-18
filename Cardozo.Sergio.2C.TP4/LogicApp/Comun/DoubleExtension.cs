using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicApp.Comun
{
    public static class DoubleExtension
    {
        public static string FormateoPrecio(this Double valor)
        {
            return string.Format($"Ganancias a la fecha: ${valor:0.00}");
        }
    }
}
