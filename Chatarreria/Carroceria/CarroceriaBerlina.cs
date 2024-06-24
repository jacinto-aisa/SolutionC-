using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Carroceria
{
    public class CarroceriaBerlina : ICarrozable
    {
        public string dameColor()
        {
            return "negro";
        }

        public double damePrecio()
        {
            return 1000;
        }
    }
}
