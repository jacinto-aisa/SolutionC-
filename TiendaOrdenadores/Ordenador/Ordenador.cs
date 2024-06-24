using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaOrdenadores.Componentes;
using TiendaOrdenadores.Comportamientos;

namespace TiendaOrdenadores.Ordenador
{
    public class Ordenador : IComponente
    {
        public List<Componente> componentes = new ();

        public int Calor { get => componentes.Sum(p => p.Calor); set => throw new NotImplementedException(); }
        public int Cores { get => componentes.Sum(p=>p.Cores); set => throw new NotImplementedException(); }
        public string Descripcion { get => "Ordenador"; set => throw new NotImplementedException(); }
        public long Megas { get => componentes.Sum(p => p.Megas); set => throw new NotImplementedException(); }
        public decimal Coste { get => componentes.Sum(p => p.Cores); set => throw new NotImplementedException(); }
        public string NumeroSerie { get => "Serie del ordenador"; set => throw new NotImplementedException(); }

        public void add(Componente componente)
        {
            if (new ValidadorComponente().isValid(componente))
                componentes.Add(componente);
        }

        public int dameNumeroPorTipo(EnumTipoComponente tipoComponente)
        {
            return componentes.Where(p=>p.TipoComponente == tipoComponente).Count();
        }

        
        

    }
}
