using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class SinDescripcion : IDescripcion
    {
        public SinDescripcion()
        {

        }

        public string Descripcion
        {
            get => "";
            set { }
        }
    }
}