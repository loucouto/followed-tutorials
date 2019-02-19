using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AritmeticaDos;

namespace LibreriaBib
{
    class Program
    {
        static void Main(string[] args)
        {
            MisMates mates = new MisMates(5, 3);

            double resultado = mates.suma();
            Console.WriteLine("El resultado de la suma es {0}", resultado);

            mates.multiplicacion();
            Console.WriteLine("El resultado de la multi es {0}", mates.R);

            Console.ReadKey();
        }
    }
}
