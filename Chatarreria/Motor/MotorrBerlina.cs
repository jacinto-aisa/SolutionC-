using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Motor
{
    public class MotorrBerlina : IMotorable
    {
        public int dameCV()
        {
            return 100;
        }

        public double damePrecio()
        {
            return 200;
        }
    }
}
