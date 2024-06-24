using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class ConMegas : IMegas
    {
        private long _megas;

        public ConMegas(long megas)
        {
            Megas = megas;
        }

        public long Megas { get => _megas; set => _megas = value; }
    }
}