using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOrdenadores.Componentes
{
    public class ValidadorComponente : IValidadorCompnente
    {
        public bool isValid(Componente miComponente)
        {

            return miComponente.Calor >= 0 && miComponente.NumeroSerie != null && miComponente.NumeroSerie != "" && miComponente.Cores >= 0 &&
                   miComponente.Coste >= 0 && miComponente.Descripcion != null && miComponente.Descripcion != "" && miComponente.Megas >= 0;
        }


    }
}
