using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Predicate<int> delegado = new Predicate<int>(Pares);
        
            List<int> numPares = numeros.FindAll(delegado);

            foreach (int n in numPares)
                Console.WriteLine(n);

            Console.WriteLine("-------------------");

            numeros.RemoveAll(delegado);

            Console.ReadLine();
        }

        static bool Pares(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }

        static bool Rango(int n)
        {
            if (n >= 3 && n<= 7)
                return true;
            else
                return false;
        }
    }
}
