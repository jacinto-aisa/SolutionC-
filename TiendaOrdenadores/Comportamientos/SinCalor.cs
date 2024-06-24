using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class SinCalor : ICalor
    {
        public SinCalor()
        {

        }

        public int Calor
        {
            get { return 0; }
            set { }
        }
    }
}