using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Comportamientos;

namespace TiendaOrdenadores.Componentes
{
    public class Componente : IComponente
    {
        private ISerie _Serie;
        private IDescripcion _Descripcion;
        private ICalor _Calor;
        private IMegas _Megas;
        private ICores _Cores;
        private IPrecio _Precio;
        private EnumTipoComponente _EnumTipoComponente;

        public Componente(ISerie serie, IDescripcion descripcion, ICalor calor, IMegas megas, ICores cores, IPrecio precio,
            EnumTipoComponente tipoComponente)
        {
            _Serie = serie;
            _Descripcion = descripcion;
            _Calor = calor;
            _Megas = megas;
            _Cores = cores;
            _Precio = precio;
            _EnumTipoComponente = tipoComponente;
        }

        public decimal Coste { get => _Precio.Coste; set => _Precio.Coste = value; }
        public string NumeroSerie { get => _Serie.NumeroSerie; set => _Serie.NumeroSerie = value; }
        public int Calor { get => _Calor.Calor; set => _Calor.Calor = value; }
        public int Cores { get => _Cores.Cores; set => _Cores.Cores = value; }
        public string Descripcion { get => _Descripcion.Descripcion; set => _Descripcion.Descripcion = value; }
        public long Megas { get => _Megas.Megas; set => _Megas.Megas = value; }
        public EnumTipoComponente TipoComponente { get => _EnumTipoComponente; set => _EnumTipoComponente = value; }
    }
}
