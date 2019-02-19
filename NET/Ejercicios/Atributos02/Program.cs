using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AritmeticaAtrib;
namespace Atributos02
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(MisMates);

            object[] atributos = t.GetCustomAttributes(false);

            foreach (DatosAttribute atributo in atributos)
            {
                Console.WriteLine("{0}", atributo.Dato);
            }

            Console.ReadLine();
        }
    }
}
