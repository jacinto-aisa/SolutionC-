using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiendaOrdenadores.Comportamientos
{
    public class ConDescripcion : IDescripcion
    {
        private string _descripcion;

        public ConDescripcion(string descripcion)
        {
            Descripcion = descripcion;
        }

        public string Descripcion
        {
            get => _descripcion;
            set => _descripcion = value;
        }
    }
}