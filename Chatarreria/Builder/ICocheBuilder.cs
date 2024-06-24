using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Builder
{
    public interface ICocheBuilder
    {
        Coche dameCoche(TiposVehiculo tipo);

    }
}
