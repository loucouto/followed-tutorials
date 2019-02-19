using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            CPunto<int> puntoI = new CPunto<int>(3, 4);

            CPunto<double> puntoD = new CPunto<double>(2.56, 1.87);

            CPunto<float> puntoF = new CPunto<float>(8.98f, 7.69f);

            Console.WriteLine(puntoI);
            Console.WriteLine(puntoD);
            Console.WriteLine(puntoF);

            puntoI.Reset();
            Console.WriteLine(puntoI);

            puntoI.EncuentraTipo();
            puntoD.EncuentraTipo();
        }
    }
}
