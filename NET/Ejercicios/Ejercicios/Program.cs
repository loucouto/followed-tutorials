using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList palabras = new ArrayList();
            int n = 0;
            int r = 0;

            palabras.AddRange(new string[] {"hola", "como", "estan?" }); //Se pasa una coleccion como parametro

            Console.WriteLine("Cantidad de elementos en el ArrayList es {0}", palabras.Count);

            for (n = 0; n < palabras.Count; n++)
            {
                Console.Write(" {0}", palabras[n]);
            }

            Console.WriteLine();
            Console.WriteLine("----");

            palabras.Add("Bien y tu?");

            foreach (string palabra in palabras)
            {
                Console.WriteLine(" {0}", palabra);
            }

            Console.WriteLine();
            Console.WriteLine("----");

            ArrayList valores = new ArrayList();
            valores.Add(5);
            valores.Add(7);
            valores.Add(4);

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("----");

            Console.WriteLine(valores.Contains(5));
            Console.WriteLine(valores.Contains(17));
            Console.WriteLine("----");

            valores.Insert(2, 55);

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            valores.Remove(55);

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("----");

            valores.RemoveAt(0);

            for (n = 0; n < valores.Count; n++)
            {
                r = (int)valores[n];
                Console.WriteLine(r);
            }

            Console.WriteLine("----");

            Console.ReadLine();
        }
    }
}
