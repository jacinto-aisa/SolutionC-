using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Componentes;
using TiendaOrdenadores.Ordenador;

namespace TiendaOrdenadores.OrdenadorV2
{
    public class BuilderOrdenadorV2 : IOrdenadorBuilderV2
    {
        public Ordenadorv2 dameOrdenador(EnumOrdenadoresTipo tipo)
        {
            Ordenadorv2 miOrdenador = null;
            ValidadorOrdenadorV2 validador = new ValidadorOrdenadorV2();
            switch (tipo)
            {
                case EnumOrdenadoresTipo.OrdenadorMaria:
                    BuilderComponenteV1 builder = new BuilderComponenteV1();
                    IComponente procesador = builder.dameComponente(EnumComponente.ProcesadorInteli7_789_XCS);
                    IComponente ram = builder.dameComponente(EnumComponente.BancoDeMemoriaSDRAM_879FH);
                    IComponente disco = builder.dameComponente(EnumComponente.DiscoDuroSanDisk_789_XX);
                    miOrdenador = new Ordenadorv2(
                        procesador, ram, disco);
                    break;
            }
            if (miOrdenador != null && validador.isValid(miOrdenador))
                return miOrdenador;
            else
                return null!;
        }
    }
}
