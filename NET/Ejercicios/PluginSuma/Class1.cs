using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TiposPlugIn02;

namespace PluginSuma
{
    public class Class1
    {
        [CInfoPlugIn(Creador = "Nicosio", Informacion = "Regresa doble, dos operando a sumar")]

        public class CSuma : IPlugInMates
        {
            public double Calcular(double pA, double pB)
            {
                double r = pA + pB;
                return r;
            }
        }

    }
}
