using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Componentes;

namespace TiendaOrdenadores.Ordenador
{
    public class BuilderOrdenadorrV1 : IOrdenadorBuilder
    {
        public Ordenador dameOrdenador(EnumOrdenadoresTipo tipo)
        {
            IValidadorOrdenador Validador = new ValidadorOrdenadorV1();
            Ordenador miOrdenador = new Ordenador();
            IBuilderComponente Constructor = new BuilderComponenteV1();

            switch (tipo)
            {
                case EnumOrdenadoresTipo.OrdenadorMaria:
                    {
                        miOrdenador.add(Constructor.dameComponente(EnumComponente.ProcesadorInteli7_789_XCS));
                        miOrdenador.add(Constructor.dameComponente(EnumComponente.BancoDeMemoriaSDRAM_879FH));
                        miOrdenador.add(Constructor.dameComponente(EnumComponente.DiscoDuroSanDisk_789_XX));
                        break;
                    }
            }
            if (Validador.isValid(miOrdenador))
                return miOrdenador;
            else
                return null!;
        }
    }
}
