using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCuatro
{
    class CSuma:ICalcular
    {
        private int a;
        private int b;
        private int r;

        public int Calculo(int pa, int pb)
        {
            a = pa;
            b = pb;
            r = a + b;

            return r;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, r);
        }
    }
}
