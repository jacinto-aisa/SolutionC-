using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcicos
{
    class Vehiculo
    {
        private IMotor _motor;
        public Vehiculo (IMotor motor)
        {
            _motor = motor;
        }
        public int GetRevoluciones()
        {
            return _motor.dameRevoluciones();
        }

    }
}
