using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashhTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable miTabla = new Hashtable();

            miTabla.Add(123, "Hola");
            miTabla.Add(234, "Saludos");
            miTabla.Add(45, "Adios");
            miTabla.Add(567, "C#");
            miTabla.Add(12763, "Programacion");

            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }

            Console.WriteLine("---");

            Console.WriteLine(miTabla.Count);

            Console.WriteLine("---");

            Console.WriteLine(miTabla[567]);
            Console.WriteLine(miTabla[445]);

            Console.WriteLine("---");

            miTabla[45] = "Avanzado";
            miTabla[300] = "Colecciones";

            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }

            Console.Write("---");

            Console.WriteLine(miTabla.Contains(567));
            Console.WriteLine(miTabla.Contains(335));

            Console.WriteLine("---");

            miTabla.Remove(234);

            foreach (DictionaryEntry elemento in miTabla)
            {
                Console.WriteLine("({0}, {1})", elemento.Key, elemento.Value);
            }

            Console.WriteLine("---");

            foreach (int llave in miTabla.Keys)
            {
                Console.WriteLine(llave);
            }

            Console.WriteLine("---");

            foreach (string valor in miTabla.Values)
            {
                Console.WriteLine(valor);
            }

            Console.ReadLine();
        }
    }
}
