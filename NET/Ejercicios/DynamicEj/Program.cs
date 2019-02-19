using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEj
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 5;
            Console.WriteLine("Tipo {0}, valor: {1}", a.GetType(), a);

            a = "Hola a todos";
            Console.WriteLine("Tipo {0}, valor: {1}", a.GetType(), a);

            Console.ReadLine();
        }
    }
}
