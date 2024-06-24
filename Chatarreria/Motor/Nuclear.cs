using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Motor
{
    internal class Nuclear : IMotorable
    {
        public int dameCV()
        {
            return 10000;
        }

        public double damePrecio()
        {
            return 100000;
        }
    }
}
