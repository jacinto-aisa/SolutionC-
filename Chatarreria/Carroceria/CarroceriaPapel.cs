using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Carroceria
{
    internal class CarroceriaPapel : ICarrozable
    {
        public string dameColor()
        {
            return "gris";
        }

        public double damePrecio()
        {
            return 1000;
        }
    }
}
