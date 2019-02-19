using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPlugIn02
{
    public interface IPlugInMates
    {
        double Calcular(double pA, double pB);
    }

    [AttributeUsage(AttributeTargets.Class)]

    public sealed class CInfoPlugIn : System.Attribute
    {
        private string creador;
        private string informacion;

        public string Creador { get { return creador; } set { creador = value; } }
        public string Informacion { get { return informacion; } set { informacion = value; } }
    }
}
