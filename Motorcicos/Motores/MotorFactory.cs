using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motorcicos.Motores
{
    public enum TipoMotor
    {
        MOTOR_AGUA = 1,
        MOTOR_DIESEL = 2,
        MOTOR_GASOLINA = 3,
        MOTOR_NUCLEAR = 4,
        ANDANDO = 5
    }
    class MotorFactory
    {
        
        public static IMotor DameMotor(TipoMotor i)
        {
            IMotor miMotor = null;
            switch (i)
            {
                case TipoMotor.MOTOR_AGUA: miMotor = new MotorDeAgua();
                    break;
                case TipoMotor.MOTOR_DIESEL: miMotor = new MotorDiesel();
                    break;
                case TipoMotor.MOTOR_GASOLINA: miMotor = new MotorGasolina();
                    break;
                case TipoMotor.MOTOR_NUCLEAR: miMotor = new MotorNuclear();
                    break;
                case TipoMotor.ANDANDO: miMotor = new Andando();
                    break;
                default: 
                    break;
            }
            return miMotor;
        }   
    }
}
