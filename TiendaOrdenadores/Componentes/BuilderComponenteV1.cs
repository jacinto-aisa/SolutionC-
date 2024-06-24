using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Comportamientos;

namespace TiendaOrdenadores.Componentes
{
    public class BuilderComponenteV1 : IBuilderComponente
    {
        public Componente dameComponente(EnumComponente tipo)
        {
            switch (tipo)
            {
                case EnumComponente.ProcesadorInteli7_789_XCS: return dameComponente("789_XCS", "Procesador Intel i7", 10, 0, 9, 134, EnumTipoComponente.Procesador);
                case EnumComponente.ProcesadorInteli7_789_XCD: return dameComponente("789_XCD", "Procesador Intel i7", 12, 0, 10, 138, EnumTipoComponente.Procesador);
                case EnumComponente.ProcesadorInteli7_789_XCT: return dameComponente("789_XCT", "Procesador Intel i7", 22, 0, 11, 138, EnumTipoComponente.Procesador);
                case EnumComponente.BancoDeMemoriaSDRAM_879FH: return dameComponente("879FH", "Banco de memoria SDRAM", 10, 512, 0, 100, EnumTipoComponente.MemoriaRAM);
                case EnumComponente.BancoDeMemoriaSDRAM_879FH_L: return dameComponente("879FH_L", "Banco de memoria SDRAM", 15, 1024, 0, 125, EnumTipoComponente.MemoriaRAM);
                case EnumComponente.BancoDeMemoriaSDRAM_879FH_T: return dameComponente("879FH_T", "Banco de memoria SDRAM", 24, 2028, 0, 150, EnumTipoComponente.MemoriaRAM);
                case EnumComponente.DiscoDuroSanDisk_789_XX: return dameComponente("789_XX", "Disco Duro Scan Disk", 10, 500000, 0, 50, EnumTipoComponente.Almacenamiento);
                case EnumComponente.DiscoDuroSanDisk_789_XX_2: return dameComponente("789_XX_2", "Disco Duro Scan Disk", 29, 1000000, 0, 90, EnumTipoComponente.Almacenamiento);
                case EnumComponente.DiscoDuroSanDisk_789_XX_3: return dameComponente("789_XX_3", "Disco Duro Scan Disk", 39, 2000000, 0, 128, EnumTipoComponente.Almacenamiento);
                default: return null!;
            }
        }

        public Componente dameComponente(string serie, string descripcion, int calor, long megas, int cores, decimal coste, EnumTipoComponente tipo)
        {
            IValidadorCompnente Validador = new ValidadorComponente();
            ISerie miSerie;
            if (serie != "")
                miSerie = new ConSerie(serie);
            else
                miSerie = new SinSerie();

            IDescripcion miDescripcion;
            if (descripcion != "")
                miDescripcion = new ConDescripcion(descripcion);
            else
                miDescripcion = new SinDescripcion();

            ICalor miCalor;
            if (calor == 0)
                miCalor = new SinCalor();
            else
                miCalor = new ConCalor(calor);

            IMegas miMegas;
            if (megas == 0)
                miMegas = new SinMegas();
            else
                miMegas = new ConMegas(megas);


            ICores miCores;
            if (cores == 0)
                miCores = new SinCores();
            else
                miCores = new ConCores(cores);

            IPrecio miPrecio;
            if (coste == 0)
                miPrecio = new SinPrecio();
            else
                miPrecio = new ConPrecio(coste);

            Componente miComponente = new (miSerie, miDescripcion, miCalor, miMegas, miCores, miPrecio, tipo);
            if (Validador.isValid(miComponente))
                return miComponente;
            else
                return null!;
        }
    }
}
