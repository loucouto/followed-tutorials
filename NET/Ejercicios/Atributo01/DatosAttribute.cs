using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributo01
{
    class DatosAttribute : System.Attribute
    {
        string dato = "";
        public string Dato { get { return dato; } set { dato = value; } }

        public DatosAttribute()
        {
        }

        public DatosAttribute(string pDato)
        {
            dato = pDato;
        }

    }
}
