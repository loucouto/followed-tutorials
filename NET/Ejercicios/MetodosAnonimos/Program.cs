using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 9;

            Func<int, int, int> delFunc = new Func<int, int, int>(Suma);

            Console.WriteLine(delFunc(x, y));

            Console.ReadLine();
        }

        /*static void RepiteMensaje(string pMensaje, int pVeces)
        {
            int n = 0;
            for (n = 0; n < pVeces; n++)
            {
                Console.WriteLine(pMensaje);
            }
        }*/

        static int Suma(int a, int b)
        {
            int r = 0;
            r = a + b;
            return r;
        }
    }
}
