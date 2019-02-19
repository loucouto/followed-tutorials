using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QueueEj
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue miQ = new Queue();

            miQ.Enqueue("Manzana");
            miQ.Enqueue("Fresa");
            miQ.Enqueue("Pera");

            foreach (string fruta in miQ)
            Console.WriteLine("->{0}", fruta);

            Console.WriteLine("------");

            Console.WriteLine("-----");

            miQ.Enqueue("Limon");
            miQ.Enqueue("Mango");
            miQ.Enqueue("Ciruela");

            Console.WriteLine("Peek {0}", miQ.Peek());

            foreach (string fruta in miQ)
                Console.WriteLine("Despues de peek -> {0}", fruta);

            Console.WriteLine("-----");

            Console.WriteLine(miQ.Count);

            Console.WriteLine("-----");

            Console.WriteLine(miQ.Contains("Mango"));
            Console.WriteLine(miQ.Contains("Manzana"));

            Console.ReadLine();

        }
    }
}
