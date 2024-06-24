using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class ConCalor : ICalor
    {
        private int _calor;

        public ConCalor(int _calor)
        {
            Calor = _calor;
        }

        public int Calor { get => _calor; set => _calor = value; }
    }
}