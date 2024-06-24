using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Builder
{
    internal class AndorraBuilder : ICocheBuilder
    {
        public Coche dameCoche(TiposVehiculo tipo)
        {
            return new Coche();

        }
    }
}
