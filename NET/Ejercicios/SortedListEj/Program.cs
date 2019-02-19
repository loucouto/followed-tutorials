using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedListEj
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList miSLista = new SortedList();

            miSLista.Add(754, "Honda");
            miSLista.Add(123, "Volvo");
            miSLista.Add(587, "Nissan");
            miSLista.Add(353, "Fiat");

            foreach (DictionaryEntry elemento in miSLista)
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);

            Console.WriteLine("---------");

            Console.WriteLine(miSLista.Count);

            Console.WriteLine(miSLista.Contains(123));
            Console.WriteLine(miSLista.Contains(678));

            Console.WriteLine(miSLista.ContainsKey(587));
            Console.WriteLine(miSLista.ContainsValue("Volvo"));

            Console.WriteLine(miSLista.GetKey(2));
            Console.WriteLine(miSLista.GetByIndex(2));

            Console.ReadLine();
        }
    }
}
