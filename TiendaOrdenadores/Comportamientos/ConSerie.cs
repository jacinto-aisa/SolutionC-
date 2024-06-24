using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class ConSerie : ISerie
    {
        public ConSerie(string _serie)
        {
            NumeroSerie = _serie;
            this.NumeroSerie = _serie;
        }

        public string NumeroSerie { get; set; }
    }
}