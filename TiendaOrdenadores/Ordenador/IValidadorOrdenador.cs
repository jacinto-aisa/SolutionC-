using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores.Ordenador
{
    public interface IValidadorOrdenador
    {
        bool isValid(Ordenador ordenador);
    }
}
