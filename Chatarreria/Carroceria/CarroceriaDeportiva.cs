using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Carroceria
{
    public class CarroceriaDeportiva : ICarrozable
    {
        public String color;
        public string dameColor()
        {
            return color;
        }

        public double damePrecio()
        {
            return 10000;
        }
    }
}
