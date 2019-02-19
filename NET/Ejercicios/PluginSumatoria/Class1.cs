using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TiposPlugIn02;

namespace PluginSumatoria
{

    [CInfoPlugIn(Creador = "Nicosio", Informacion = "Regresa doble, dos operando a sumar")]

    public class CSumatoria : IPlugInMates
    {
        public double Calcular(double pA, double pB)
        {
            int n = 0;
            double sumatoria = 0;
            for (n = 1; n <= pA; n++)
                sumatoria += n;

            return sumatoria;
        }
    }
    
}
