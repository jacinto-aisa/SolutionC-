using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Comportamientos;

namespace TiendaOrdenadores.Componentes
{
    public interface IBuilderComponente
    {
        Componente dameComponente(EnumComponente tipo);
        Componente dameComponente(string serie, string descripcion, int calor, long megas, int cores, decimal coste, EnumTipoComponente tipo);

    }
}
