using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class ConCores : ICores
    {
        private int _cores;

        public ConCores(int cores)
        {
            Cores = cores;
        }

        public int Cores { get => _cores; set => _cores = value; }
    }
}