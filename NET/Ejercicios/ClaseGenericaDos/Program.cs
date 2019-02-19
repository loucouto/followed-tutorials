using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseGenericaDos
{
    class Program
    {
        static void Main(string[] args)
        {
            COperaciones<int> miOperacion = new COperaciones<int>();
            COperaciones<string> miOperacionS = new COperaciones<string>();

            Console.WriteLine(miOperacion.Suma(5, 4));
            Console.WriteLine(miOperacionS.Multi("hola", "a todos"));
        }
    }
}
