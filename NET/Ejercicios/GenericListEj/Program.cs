using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListEj
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> valores = new List<int>();
            int n = 0;
            int r = 0;

            valores.Add(7);
            valores.Add(5);
            valores.Add(4);
            valores.Add(3);
            valores.Add(8);
            valores.Add(9);

            for(n=0; n<valores.Count;n++)
            {
                r = valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("------");

            Console.WriteLine(valores.Contains<int>(5));
            Console.WriteLine(valores.Contains<int>(17));

            Console.WriteLine("------");

            Console.WriteLine(valores.IndexOf(4));

            Console.WriteLine("-----");

            valores.Insert(2, 55);

            foreach (int valor in valores)
                Console.WriteLine(valor);

            Console.WriteLine("------");

            valores.RemoveAt(3);

            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }

            Console.WriteLine("-----");
        }
    }
}
