using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Ordenador;

namespace TiendaOrdenadores.OrdenadorV2
{
    public interface IOrdenadorBuilderV2
    {
            
        Ordenadorv2 dameOrdenador(EnumOrdenadoresTipo tipo);
    }
}

