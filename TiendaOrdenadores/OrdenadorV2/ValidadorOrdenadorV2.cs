using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Componentes;
using TiendaOrdenadores.Ordenador;

namespace TiendaOrdenadores.OrdenadorV2
{
    internal class ValidadorOrdenadorV2 : IValidadorOrdenadorV2
    {
        public bool isValid(Ordenadorv2 ordenador)
        {
            IValidadorCompnente validador = new ValidadorComponente();
            return (ordenador._Procesador != null &&
                (ordenador._Procesador as Componente).TipoComponente == Comportamientos.EnumTipoComponente.Procesador &&
                ordenador._RAM != null &&
                (ordenador._RAM as Componente).TipoComponente == Comportamientos.EnumTipoComponente.MemoriaRAM &&
                ordenador._Disco != null &&
                (ordenador._Disco as Componente).TipoComponente == Comportamientos.EnumTipoComponente.Almacenamiento &&
                validador.isValid((ordenador._Procesador as Componente)!) &&
                validador.isValid((ordenador._RAM as Componente)!) &&
                validador.isValid((ordenador._Disco as Componente)!));
        }
       }
}
