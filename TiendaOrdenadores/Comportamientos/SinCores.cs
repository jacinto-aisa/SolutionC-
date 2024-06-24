using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class SinCores : ICores
    {
        public SinCores()
        {
        }

        public int Cores
        {
            get { return 0; }
            set { }
        }
    }
}