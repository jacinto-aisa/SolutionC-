using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Comportamientos;

namespace TiendaOrdenadores.Componentes
{
    public interface IComponente : ICalor, ICores, IDescripcion, IMegas, IPrecio, ISerie
    {
    }
}
