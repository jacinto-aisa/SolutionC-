using Motorcicos.Motores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcicos
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotor miMotor = new MotorDeAgua();
            Vehiculo miVehiculo = new Vehiculo(miMotor);
            List<IMotor> lista = new List<IMotor>();
            lista.Add(MotorFactory.DameMotor(TipoMotor.MOTOR_AGUA));
            lista.Add(MotorFactory.DameMotor(TipoMotor.MOTOR_DIESEL));
            lista.Add(MotorFactory.DameMotor(TipoMotor.MOTOR_GASOLINA));
            lista.Add(MotorFactory.DameMotor(TipoMotor.MOTOR_NUCLEAR));
            lista.Add(MotorFactory.DameMotor(TipoMotor.ANDANDO));

            foreach (var item in lista)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.dameRevoluciones().ToString());
            }
            Console.ReadLine();
        }
    }
}
