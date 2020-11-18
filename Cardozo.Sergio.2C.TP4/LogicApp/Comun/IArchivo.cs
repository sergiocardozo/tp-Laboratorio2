using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicApp.Comun
{
    public interface IArchivo
    {
        string Texto { get; }
        string Ruta { get; }
    }
}
