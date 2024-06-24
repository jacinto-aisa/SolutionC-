using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class SinMegas : IMegas
    {
        public SinMegas()
        {

        }

        public long Megas
        {
            get { return 0; }
            set { }
        }
    }
}