using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributo01
{
    //[Obsolete]
    [Obsolete("Usa la nueva version CPrueba2")]
    class CPrueba
    {
        public CPrueba()
        {
            Console.WriteLine("Version 1");
        }  
    }

    [Datos("Clase por Nicosio")]
    class CPrueba2
    {
        public CPrueba2()
        {
            Console.WriteLine("Version 2");
        }
    }
}
