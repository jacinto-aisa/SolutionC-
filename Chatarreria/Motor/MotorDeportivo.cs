using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Motor
{
    internal class MotorDeportivo : IMotorable
    {
        public int dameCV()
        {
            return 400;
        }

        public double damePrecio()
        {
            return 300;
        }
    }
}
