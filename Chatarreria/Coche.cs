using Chatarreria.Carroceria;
using Chatarreria.Motor;
using Chatarreria.Ruedas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Transactions;

namespace Chatarreria
{
    public class Coche
    {
        public ICarrozable carroceria;
        public IMotorable motor;
        public IRuedable ruedas;

        public double dameImporte()
        {
            return carroceria.damePrecio() + motor.damePrecio() + ruedas.damePrecio();
        }
        public String dameInformacion()
        {
            return "El coche, tiene un motor de  " + this.motor.dameCV() + " CV, la carroceria es de color: " + this.carroceria.dameColor() +
                " Las ruedas tienen una goma de: " + this.ruedas.dameGoma();
        }
    }
}
