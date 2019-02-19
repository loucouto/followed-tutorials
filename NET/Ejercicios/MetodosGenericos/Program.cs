using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 3;

            Console.WriteLine("x={0}, y={1}", x, y);
            Intercambio<int>(ref x, ref y);
            Console.WriteLine("x={0}, y={1}", x, y);

            double m = 78.9;
            double n = 98.6;

            Console.WriteLine("m={0}, n={1}", m, n);
            Intercambio<int>(ref x, ref y);
            Console.WriteLine("m={0}, n={1}", m, n);

            string o = "Hola";
            string p = "a todos";

            Console.WriteLine("o={0}, p={1}", o, p);
            Intercambio<int>(ref x, ref y);
            Console.WriteLine("o={0}, p={1}", o, p);

            Console.ReadLine();
        }

        static void Intercambio<T>(ref T a, ref T b)
        {
            T temporal;
            temporal = a;
            a = b;
            b = temporal;
        }
    }
}
