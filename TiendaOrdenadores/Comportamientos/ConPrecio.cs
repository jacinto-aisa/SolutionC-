using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class ConPrecio : IPrecio
    {
        public ConPrecio(decimal coste)
        {
            Coste = coste;
        }
        private decimal _coste;

        public decimal Coste { get => _coste; set => _coste = value; }
    }
}