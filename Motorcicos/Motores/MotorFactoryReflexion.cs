using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Motorcicos.Motores
{
    public class MotorFactoryReflexion
    {
        private static Dictionary<String, Type> tiposInstanciables = new Dictionary<string, Type>();
        public static List<String> Automatico()
        {
            tiposInstanciables = (from tipo in Assembly.GetExecutingAssembly().GetTypes()
                                  where tipo.GetInterface(typeof(IMotor).ToString()) != null
                                  select tipo).ToDictionary(t => t.ToString(), t => t);
            return tiposInstanciables.Keys.ToList<String>();
        }

        private static Type ObtenerTipo(string nombreTipo)
        {
            if (tiposInstanciables == null)
                return null;
            else
                return (tiposInstanciables.ContainsKey(nombreTipo) ? tiposInstanciables[nombreTipo] : null);
        }
        public static IMotor CreateInstance(string tipoMotor)
        {
            // Usamos Activator.CreateInstance(tipo) para instanciar el objeto de forma dinamica
            IMotor resultado = (IMotor)Activator.CreateInstance(ObtenerTipo(tipoMotor));

            return resultado;
        }
    }
}
