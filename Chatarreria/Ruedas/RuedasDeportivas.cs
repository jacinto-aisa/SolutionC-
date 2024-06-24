using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Ruedas
{
    internal class RuedasDeportivas : IRuedable
    {
        public string dameGoma()
        {
            return "Goma competición";
        }

        public double damePrecio()
        {
            return 240;
        }
    }
}
