using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiempoVidaObj
{
    class Program
    {
        static void Main(string[] args)
        {
            long bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine("El heap usa {0} bytes", bytesHeap);

            int maximaGeneracion = GC.MaxGeneration + 1;
            Console.WriteLine("Se tiene {0} generaciones", maximaGeneracion);

            CPrueba prueba1 = new CPrueba(5);

            bytesHeap = GC.GetTotalMemory(false);
            Console.WriteLine("El heap usa {0} bytes", bytesHeap);

            int generacionInstancia = GC.GetGeneration(prueba1);

            Console.WriteLine("La generacion de la instancia es {0}", generacionInstancia);
        }
    }
}
