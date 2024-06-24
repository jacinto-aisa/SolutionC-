using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class SinPrecio : IPrecio
    {
        public SinPrecio()
        {

        }

        public decimal Coste
        {
            get { return 0; }
            set { }
        }
    }
}