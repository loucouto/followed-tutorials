using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray miArreglo = new BitArray(new byte[] {1, 2, 4, 8, 16});

            Console.WriteLine(miArreglo.Count);
            MuestraArreglo(miArreglo);

            Console.WriteLine("---");

            Console.WriteLine(miArreglo.Get(0));

            miArreglo.Set(3, true);
            MuestraArreglo(miArreglo);
            Console.WriteLine(miArreglo.Get(3));

            Console.WriteLine("---");

            BitArray arreglo2 = (BitArray)miArreglo.Clone();
            MuestraArreglo(arreglo2);

            arreglo2.Not();
            MuestraArreglo(arreglo2);

            Console.WriteLine("---");

            BitArray arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 15 });
            MuestraArreglo(arreglo3, "arreglo3");
            Console.WriteLine("--- ");

            arreglo3.Or(miArreglo);
            MuestraArreglo(miArreglo, "miArreglo");
            MuestraArreglo(arreglo3, "arreglo3");
            Console.WriteLine("============");

            arreglo3.And(miArreglo);
            MuestraArreglo(arreglo3, "arreglo3");
            Console.WriteLine("---");

            arreglo3 = new BitArray(new byte[] { 5, 7, 9, 13, 21 });
            MuestraArreglo(miArreglo, "miArreglo");
            MuestraArreglo(arreglo3, "arreglo3");
            Console.WriteLine("--- ");

            arreglo3.Xor(miArreglo);
            MuestraArreglo(arreglo3, "arreglo3");
            Console.WriteLine("---");

            Console.ReadLine();
        }

        public static void MuestraArreglo(BitArray pArreglo, string pNombre="")
        {
            int c = 0;

            Console.Write("{0}\t", pNombre);

            foreach (bool b in pArreglo)
            {
                c++;
                if (b)
                    Console.Write("1");
                else
                    Console.Write("0");
                if (c % 8 == 0)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
