using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores.Componentes
{
    public interface IValidadorCompnente
    {
        bool isValid(Componente miComponente);
    }
}
