using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            List<int> numPares = numeros.FindAll(i => (i % 2) == 0);

            foreach(int n in numPares)
                Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
