using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEj
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack miStack = new Stack();

            miStack.Push("Manzana");
            miStack.Push("Pera");
            miStack.Push("Ciruela");
            miStack.Push("Mango");

            foreach (string fruta in miStack)
                Console.WriteLine("->{0}", fruta);

            Console.WriteLine("----");

            Console.WriteLine(miStack.Pop());

            foreach (string fruta in miStack)
                Console.WriteLine("->{0}", fruta);

            Console.WriteLine("-------");

            Console.WriteLine(miStack.Peek());

            foreach (string fruta in miStack)
                Console.WriteLine("->{0}", fruta);

            Console.WriteLine("------");

            Console.WriteLine(miStack.Count);

            Console.WriteLine("------");

            Console.ReadLine();
        }
    }
}
