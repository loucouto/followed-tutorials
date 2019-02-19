using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoGenerico
{
    class Program
    {
        public delegate void miDelegado<T>(T p);

        static void Main(string[] args)
        {
            miDelegado<string> delCadena = new miDelegado<string>(HandlerString);
            delCadena("Hola a todos");

            miDelegado<double> delDoble = new miDelegado<double>(HandlerDouble);
            delDoble(58.7);
        }

        static void HandlerString(string p)
        {
            Console.WriteLine("Uso string como tipo y el valor es {0}", p);
        }

        static void HandlerDouble(double p)
        {
            Console.WriteLine("Uso double como tipo y el valor es {0}", p);
        }
    }
}
