using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Ruedas
{
    internal class RuedasBerlina : IRuedable
    {
        public string dameGoma()
        {
            return "Goma normal";
        }

        public double damePrecio()
        {
            return 90;
        }
    }
}
