using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class SinSerie : ISerie
    {
        public SinSerie()
        {

        }

        public string NumeroSerie
        {
            get { return ""; }
            set { }
        }
    }
}