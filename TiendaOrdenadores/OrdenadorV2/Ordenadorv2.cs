using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Componentes;

namespace TiendaOrdenadores.OrdenadorV2
{
    public class Ordenadorv2 : IComponente
    {
        public IComponente _Procesador;
        public IComponente _RAM;
        public IComponente _Disco;

        public Ordenadorv2(IComponente procesador, IComponente ram, IComponente disco)
        {
            _Procesador = procesador;
            _RAM = ram;
            _Disco = disco;
        }

        public int Calor { get => _Procesador.Calor + _RAM.Calor + _Disco.Calor; set => throw new NotImplementedException(); }
        public int Cores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Descripcion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long Megas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Coste { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NumeroSerie { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
