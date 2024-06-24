using Chatarreria.Carroceria;
using Chatarreria.Motor;
using Chatarreria.Ruedas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatarreria.Builder
{
    public class BuilderCoche : ICocheBuilder
    {
        public Coche dameCoche(TiposVehiculo tipo)
        {
           Coche miCoche = new Coche();
           switch(tipo)
            {
                case TiposVehiculo.Deportivo:
                    {
                        CarroceriaDeportiva CarroceriaCocheDep = new CarroceriaDeportiva();
                        CarroceriaCocheDep.color = "Rojo";
                        MotorDeportivo MotorDep = new MotorDeportivo();
                        RuedasDeportivas RuedasDep = new RuedasDeportivas();
                        miCoche.carroceria = CarroceriaCocheDep;
                        miCoche.ruedas = RuedasDep;
                        miCoche.motor = MotorDep;
                        break;
                    }
                case TiposVehiculo.Berlina:
                    {
                        ICarrozable Carroceria = new CarroceriaBerlina();
                        miCoche.carroceria = Carroceria;
                        IRuedable ruedasDeportivas = new RuedasDeportivas();
                        miCoche.ruedas = ruedasDeportivas;
                        IMotorable motor = new Nuclear();
                        miCoche.motor = motor;
                        break;
                    }
            }
            return miCoche;
        }
    }
}
