using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntadores
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int valor = 5;

                int* p;

                p = &valor;

                Console.WriteLine(*p);

                *p = 67;
                Console.WriteLine(*p);
                Console.WriteLine(valor);
            }

            Console.WriteLine("----Haremos un swap------");

            int a = 3;
            int b = 8;

            Console.WriteLine("a={0}, b={1}", a, b);

            unsafe { swap(&a, &b); }
            Console.WriteLine("a={0}, b={1}", a, b);
        }

        unsafe public static void swap(int* n, int* m)
        {
            int temp = *m;
            *m = *n;
            *n = temp;
        }
    }
}
