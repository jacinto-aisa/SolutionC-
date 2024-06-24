using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Comportamientos;

namespace TiendaOrdenadores.Ordenador
{
    public class ValidadorOrdenadorV1 : IValidadorOrdenador
    {
        public bool isValid(Ordenador ordenador)
        {
            return (
            ordenador.dameNumeroPorTipo(EnumTipoComponente.Procesador) ==1 && 
            ordenador.dameNumeroPorTipo(EnumTipoComponente.MemoriaRAM) ==1 &&
            ordenador.dameNumeroPorTipo(EnumTipoComponente.Almacenamiento)==1);
        }
    }
}
